using System.Data;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title", typeof(string));
            notes.Columns.Add("Description", typeof(string));

            PreviewsNotesGrid.DataSource = notes;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[PreviewsNotesGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid note!!!");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[PreviewsNotesGrid.CurrentCell.RowIndex]["Title"] = TitleInput.Text;
                notes.Rows[PreviewsNotesGrid.CurrentCell.RowIndex]["Description"] = DescInput.Text;
            }
            else
            {
                notes.Rows.Add(TitleInput.Text, DescInput.Text);
            }

            DescInput.Text = "";
            TitleInput.Text = "";
            editing = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DescInput.Text = "";
            TitleInput.Text = "";
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            TitleInput.Text = notes.Rows[PreviewsNotesGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescInput.Text = notes.Rows[PreviewsNotesGrid.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void note_Click(object sender, EventArgs e)
        {

        }

        private void PreviewsNotesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DescInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PreviewsNotesGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleInput.Text = notes.Rows[PreviewsNotesGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescInput.Text = notes.Rows[PreviewsNotesGrid.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }
    }
}