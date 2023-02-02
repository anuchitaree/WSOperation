using WSOperation.Models;
using WSOperation.Modules.Initial;

namespace WSOperation.ChildFrm
{
    public partial class RegistrationFrm : Form
    {
        public RegistrationFrm()
        {
            InitializeComponent();
        }

        private void RegistrationFrm_Load(object sender, EventArgs e)
        {
            string path1 = $"{Environment.CurrentDirectory}\\Static";

            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }

            string path2 = $"{path1}\\Sourcefiles";

            if (!Directory.Exists(path2))
            {
                Directory.CreateDirectory(path2);
            }

            string[] header = new string[] { "key", "No", "Part number", "Source file" };
            int[] width = new int[] { 5, 30, 120, 500 };

            DataGridViewInit.Pattern_1(DgvList, header, width);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            Browse();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            RegistrationSave();
        }

        private void BtnListWs_Click(object sender, EventArgs e)
        {
            ListUp();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BtnCopyTo_Click(object sender, EventArgs e)
        {
            CopyTo();
        }
       
        //=================//
        #region Sub Program

        private void RegistrationSave()
        {
            try
            {
                string p = Directory.GetCurrentDirectory();

                string path = $"{p}\\static\\SourceFiles";

                FileInfo fi = new FileInfo(TbDestination.Text);

                var filename = TbDestination.Text.Split('\\');
                var len = filename.Length;

                var name = filename[len - 1];

                //var uuid = Guid.NewGuid().ToString();

                string destination = $"{path}\\{name}";

                fi.CopyTo(destination, true);


                using (var db = new DBContext())
                {
                    var record = new WorkingStandard()
                    {
                        Partnumber = ScanText.Text.Substring(0, 10),
                        Destination = destination,
                    };
                    db.WorkingStandards.Add(record);
                    db.SaveChanges();
                    MessageBox.Show("Save Image completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ScanText.Text = TbDestination.Text = String.Empty;

                }


            }
            catch
            {
                MessageBox.Show("Save Image is not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Browse()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Browse Image File";

            openFileDialog1.DefaultExt = "jpg";

            openFileDialog1.ReadOnlyChecked = true;

            openFileDialog1.ShowReadOnly = true;


            openFileDialog1.Filter = "Image files (*.jpg;*.png)|*.jpg;*png|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TbDestination.Text = openFileDialog1.FileName;
            }
        }

        private void ListUp()
        {
            try
            {
                using (var db = new DBContext())
                {

                    var wsLists = db.WorkingStandards.ToList();

                    DgvList.Rows.Clear();
                    int i = 0;
                    foreach (var item in wsLists)
                    {
                        DgvList.Rows.Add(item.Id, i++, item.Partnumber, item.Destination);
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Delete()
        {
            try
            {
                if (DgvList.RowCount > 0)
                {
                    DialogResult r = MessageBox.Show("Are you sure ?", "Delete Working-Standard List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int row = DgvList.CurrentRow.Index;

                        int key = Convert.ToInt32(DgvList.Rows[row].Cells[0].Value.ToString());
                        DgvList.Rows.RemoveAt(row);

                        using (var db = new DBContext())
                        {
                            var exist = db.WorkingStandards.Where(x => x.Id == key).ToList();
                            db.WorkingStandards.RemoveRange(exist);
                            db.SaveChanges();
                            MessageBox.Show("Delete image completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Delete image is NOT completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void CopyTo()
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog
                {
                    RootFolder = Environment.SpecialFolder.Desktop,
                    SelectedPath = @"C:\",
                    ShowNewFolderButton = true
                };

                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = folderDlg.SelectedPath;

                    int row = DgvList.CurrentRow.Index;

                    string source = DgvList.Rows[row].Cells[3].Value.ToString()!;

                    string[] files = source.Split('\\');
                    int len = files.Length;
                    string filename = files[len - 1];


                    string destination = $"{path}\\{filename}";
                    FileInfo fi = new FileInfo(destination);
                    fi.CopyTo(destination, true);
                    MessageBox.Show("Copy image to destination completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Copy image to destination Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

       
    }
}
