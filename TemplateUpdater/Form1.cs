using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace TemplateUpdater
{
    public partial class Form1 : Form
    {
        private string tempDir; 
        private string rutaSalidaZip; 

        public Form1()
        {
            InitializeComponent();
        }

        // Este evento se dispara cuando el formulario carga
        private void Form1_Load(object sender, EventArgs e)
        {
            // Preparamos la cuadrícula "dgvReglas"
            dgvReglas.Columns.Add("Original", "Texto Original");
            dgvReglas.Columns.Add("Nuevo", "Texto Nuevo");

            // Hacemos que las columnas llenen el espacio
            dgvReglas.Columns["Original"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReglas.Columns["Nuevo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Conectamos el evento que actualiza la vista previa
            dgvReglas.CellValueChanged += dgvReglas_CellValueChanged;
        }

        // --- MANEJADORES DE EVENTOS DE BOTONES ---

        private void btnCargarZip_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos ZIP (*.zip)|*.zip";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Limpiar todo si ya había algo cargado
                    LimpiarDirectorioTemporal();
                    dgvReglas.Rows.Clear();
                    tvPreview.Nodes.Clear();

                    // 1. Crear directorio temporal
                    tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                    Directory.CreateDirectory(tempDir);

                    try
                    {
                        // 2. Descomprimir
                        ZipFile.ExtractToDirectory(ofd.FileName, tempDir);

                        // 3. Generar la primera vista previa
                        ActualizarVistaPrevia();
                        MessageBox.Show("Archivo cargado. Añade tus reglas de reemplazo.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al leer el ZIP: {ex.Message}");
                        LimpiarDirectorioTemporal();
                    }
                }
            }
        }

        private void btnRutaSalida_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo ZIP (*.zip)|*.zip";
                sfd.Title = "Guardar nuevo ZIP como...";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    rutaSalidaZip = sfd.FileName;
                    MessageBox.Show($"Ruta de salida establecida: {rutaSalidaZip}");
                }
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tempDir) || string.IsNullOrEmpty(rutaSalidaZip))
            {
                MessageBox.Show("Por favor, carga un ZIP y selecciona una ruta de salida.");
                return;
            }

            this.Enabled = false;
            btnActualizar.Text = "Procesando...";

            // Obtener las reglas finales
            var reglas = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dgvReglas.Rows)
            {
                if (row.IsNewRow || row.Cells["Original"].Value == null) continue;
                string original = row.Cells["Original"].Value.ToString();
                string nuevo = row.Cells["Nuevo"].Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(original) && !reglas.ContainsKey(original))
                {
                    reglas.Add(original, nuevo);
                }
            }

            try
            {
                // Usar Task.Run para no congelar la app
                await Task.Run(() =>
                {
                    // --- 1. Reemplazar contenido DENTRO de los archivos ---
                    var allFiles = Directory.GetFiles(tempDir, "*.*", SearchOption.AllDirectories);
                    foreach (string file in allFiles)
                    {
                        string content = File.ReadAllText(file);
                        foreach (var regla in reglas)
                        {
                            content = content.Replace(regla.Key, regla.Value);
                        }
                        File.WriteAllText(file, content);
                    }

                    // --- 2. Renombrar los NOMBRES de archivos ---
                    allFiles = Directory.GetFiles(tempDir, "*.*", SearchOption.AllDirectories);
                    foreach (string file in allFiles)
                    {
                        string nombreArchivo = Path.GetFileName(file);
                        string nuevoNombre = nombreArchivo;
                        foreach (var regla in reglas) { nuevoNombre = nuevoNombre.Replace(regla.Key, regla.Value); }

                        if (nombreArchivo != nuevoNombre)
                        {
                            File.Move(file, Path.Combine(Path.GetDirectoryName(file), nuevoNombre));
                        }
                    }

                    // --- 3. Renombrar NOMBRES de carpetas (¡MUY IMPORTANTE!) ---
                    var allDirs = Directory.GetDirectories(tempDir, "*", SearchOption.AllDirectories);
                    var sortedDirs = allDirs.OrderByDescending(d => d.Length); // CRÍTICO

                    foreach (string dir in sortedDirs)
                    {
                        string nombreDir = Path.GetFileName(dir);
                        string nuevoNombre = nombreDir;
                        foreach (var regla in reglas) { nuevoNombre = nuevoNombre.Replace(regla.Key, regla.Value); }

                        if (nombreDir != nuevoNombre)
                        {
                            Directory.Move(dir, Path.Combine(Path.GetDirectoryName(dir), nuevoNombre));
                        }
                    }

                    // --- 4. Comprimir todo ---
                    if (File.Exists(rutaSalidaZip)) File.Delete(rutaSalidaZip);
                    ZipFile.CreateFromDirectory(tempDir, rutaSalidaZip);
                });

                MessageBox.Show("¡Proceso completado con éxito!", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
            finally
            {
                // Limpiar todo
                LimpiarDirectorioTemporal();
                dgvReglas.Rows.Clear();
                tvPreview.Nodes.Clear();
                this.Enabled = true;
                btnActualizar.Text = "Actualizar y Comprimir";
            }
        }

        // --- MANEJADORES DE OTROS CONTROLES ---

        private void dgvReglas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Solo actualiza si hay un ZIP cargado
            if (string.IsNullOrEmpty(tempDir)) return;

            // Llama a la función que actualiza el árbol de vista previa
            ActualizarVistaPrevia();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarDirectorioTemporal();
        }

        // --- FUNCIONES DE AYUDA (HELPERS) ---

        private void ActualizarVistaPrevia()
        {
            // 1. Obtener todas las reglas de la cuadrícula
            var reglas = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dgvReglas.Rows)
            {
                if (row.IsNewRow || row.Cells["Original"].Value == null) continue;
                string original = row.Cells["Original"].Value.ToString();
                string nuevo = row.Cells["Nuevo"].Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(original) && !reglas.ContainsKey(original))
                {
                    reglas.Add(original, nuevo);
                }
            }

            // 2. Limpiar y recargar el árbol
            tvPreview.Nodes.Clear();

            // 3. Llamar a la función recursiva que crea el árbol
            CargarArbolPreview(tempDir, tvPreview.Nodes, reglas);
            tvPreview.ExpandAll();
        }

        private void CargarArbolPreview(string directorio, TreeNodeCollection nodosPadre, Dictionary<string, string> reglas)
        {
            try
            {
                // Procesa subcarpetas
                foreach (string dir in Directory.GetDirectories(directorio))
                {
                    string nombreDir = Path.GetFileName(dir);
                    string nombreNuevo = nombreDir;
                    foreach (var regla in reglas) { nombreNuevo = nombreNuevo.Replace(regla.Key, regla.Value); }

                    TreeNode nodo = new TreeNode(nombreNuevo);
                    nodosPadre.Add(nodo);
                    CargarArbolPreview(dir, nodo.Nodes, reglas); // Recursión
                }

                // Procesa archivos
                foreach (string file in Directory.GetFiles(directorio))
                {
                    string nombreArchivo = Path.GetFileName(file);
                    string nombreNuevo = nombreArchivo;
                    foreach (var regla in reglas) { nombreNuevo = nombreNuevo.Replace(regla.Key, regla.Value); }

                    nodosPadre.Add(new TreeNode(nombreNuevo));
                }
            }
            catch { /* Ignorar errores de acceso */ }
        }

        private void LimpiarDirectorioTemporal()
        {
            if (!string.IsNullOrEmpty(tempDir) && Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, true); // true = borrado recursivo
            }
        }
    }
}