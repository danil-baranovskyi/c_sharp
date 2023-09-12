namespace NoteTakingApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleInput = new TextBox();
            DescInput = new TextBox();
            title = new Label();
            note = new Label();
            PreviewsNotesGrid = new DataGridView();
            LoadBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            AddBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PreviewsNotesGrid).BeginInit();
            SuspendLayout();
            // 
            // TitleInput
            // 
            TitleInput.BackColor = SystemColors.ControlLight;
            TitleInput.Location = new Point(345, 38);
            TitleInput.Name = "TitleInput";
            TitleInput.Size = new Size(443, 23);
            TitleInput.TabIndex = 0;
            TitleInput.TextChanged += TitleInput_TextChanged;
            // 
            // DescInput
            // 
            DescInput.BackColor = SystemColors.ControlLight;
            DescInput.Location = new Point(345, 102);
            DescInput.Multiline = true;
            DescInput.Name = "DescInput";
            DescInput.Size = new Size(443, 338);
            DescInput.TabIndex = 1;
            DescInput.TextChanged += DescInput_TextChanged;
            // 
            // title
            // 
            title.Location = new Point(345, 12);
            title.Name = "title";
            title.Size = new Size(443, 23);
            title.TabIndex = 2;
            title.Text = "Title: ";
            title.Click += title_Click;
            // 
            // note
            // 
            note.Location = new Point(345, 77);
            note.Name = "note";
            note.Size = new Size(443, 22);
            note.TabIndex = 3;
            note.Text = "Note: ";
            note.Click += note_Click;
            // 
            // PreviewsNotesGrid
            // 
            PreviewsNotesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PreviewsNotesGrid.BackgroundColor = SystemColors.ControlLight;
            PreviewsNotesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PreviewsNotesGrid.Location = new Point(12, 12);
            PreviewsNotesGrid.Name = "PreviewsNotesGrid";
            PreviewsNotesGrid.RowTemplate.Height = 25;
            PreviewsNotesGrid.Size = new Size(276, 343);
            PreviewsNotesGrid.TabIndex = 4;
            PreviewsNotesGrid.CellContentClick += PreviewsNotesGrid_CellContentClick;
            PreviewsNotesGrid.CellContentDoubleClick += PreviewsNotesGrid_CellContentDoubleClick;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.Linen;
            LoadBtn.Location = new Point(12, 362);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(135, 36);
            LoadBtn.TabIndex = 5;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Linen;
            DeleteBtn.ForeColor = Color.Red;
            DeleteBtn.Location = new Point(153, 404);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(135, 37);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Linen;
            SaveBtn.Location = new Point(12, 404);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(135, 36);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Linen;
            AddBtn.Location = new Point(153, 362);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(135, 36);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(AddBtn);
            Controls.Add(SaveBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(LoadBtn);
            Controls.Add(PreviewsNotesGrid);
            Controls.Add(note);
            Controls.Add(title);
            Controls.Add(DescInput);
            Controls.Add(TitleInput);
            Name = "NoteTaker";
            Text = "Note Taker ";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)PreviewsNotesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleInput;
        private TextBox DescInput;
        private Label title;
        private Label note;
        private DataGridView PreviewsNotesGrid;
        private Button LoadBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Button AddBtn;
    }
}