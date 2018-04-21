namespace ColetorGui
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPadrao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.dgChamadaClasse = new System.Windows.Forms.DataGridView();
            this.bsChamadaPorClasse = new System.Windows.Forms.BindingSource(this.components);
            this.escolaDataSet = new ColetorGui.EscolaDataSet();
            this.dgClasses = new System.Windows.Forms.DataGridView();
            this.bsClasse = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.dgDebugChamada = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsChamada = new System.Windows.Forms.BindingSource(this.components);
            this.dgDebugResponsavel = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsResponsavel = new System.Windows.Forms.BindingSource(this.components);
            this.dgDebugClasse = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDebugAluno = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAluno = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageAlunosPorClasse = new System.Windows.Forms.TabPage();
            this.dgAlunosClasse = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboClasse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageResponsaveis = new System.Windows.Forms.TabPage();
            this.dgResponsaveis = new System.Windows.Forms.DataGridView();
            this.tabPageApp = new System.Windows.Forms.TabPage();
            this.dgChamada = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alunoTableAdapter = new ColetorGui.EscolaDataSetTableAdapters.AlunoTableAdapter();
            this.chamadaTableAdapter = new ColetorGui.EscolaDataSetTableAdapters.ChamadaTableAdapter();
            this.classeTableAdapter = new ColetorGui.EscolaDataSetTableAdapters.ClasseTableAdapter();
            this.responsavelTableAdapter = new ColetorGui.EscolaDataSetTableAdapters.ResponsavelTableAdapter();
            this.chamadaPorClasseTableAdapter = new ColetorGui.EscolaDataSetTableAdapters.ChamadaTableAdapter();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenteDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.responsavelDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeResponsavelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDescricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamadaClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChamadaPorClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClasse)).BeginInit();
            this.tabPageDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugChamada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChamada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAluno)).BeginInit();
            this.tabPageAlunosPorClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunosClasse)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageResponsaveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResponsaveis)).BeginInit();
            this.tabPageApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamada)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPadrao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPadrao
            // 
            this.toolStripStatusLabelPadrao.Name = "toolStripStatusLabelPadrao";
            this.toolStripStatusLabelPadrao.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageClasses);
            this.tabControl.Controls.Add(this.tabPageDebug);
            this.tabControl.Controls.Add(this.tabPageAlunosPorClasse);
            this.tabControl.Controls.Add(this.tabPageResponsaveis);
            this.tabControl.Controls.Add(this.tabPageApp);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 641);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.dgChamadaClasse);
            this.tabPageClasses.Controls.Add(this.dgClasses);
            this.tabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasses.Size = new System.Drawing.Size(792, 615);
            this.tabPageClasses.TabIndex = 1;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // dgChamadaClasse
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgChamadaClasse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgChamadaClasse.AutoGenerateColumns = false;
            this.dgChamadaClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamadaClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn1,
            this.alunoDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn3,
            this.presenteDataGridViewCheckBoxColumn1,
            this.responsavelDataGridViewTextBoxColumn2,
            this.nomeResponsavelDataGridViewTextBoxColumn1,
            this.classeDataGridViewTextBoxColumn2,
            this.classeDescricaoDataGridViewTextBoxColumn1});
            this.dgChamadaClasse.DataSource = this.bsChamadaPorClasse;
            this.dgChamadaClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChamadaClasse.Location = new System.Drawing.Point(3, 377);
            this.dgChamadaClasse.Name = "dgChamadaClasse";
            this.dgChamadaClasse.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgChamadaClasse.RowTemplate.Height = 30;
            this.dgChamadaClasse.Size = new System.Drawing.Size(786, 235);
            this.dgChamadaClasse.TabIndex = 1;
            this.dgChamadaClasse.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChamadaClasse_RowLeave);
            // 
            // bsChamadaPorClasse
            // 
            this.bsChamadaPorClasse.DataMember = "Chamada";
            this.bsChamadaPorClasse.DataSource = this.escolaDataSet;
            // 
            // escolaDataSet
            // 
            this.escolaDataSet.DataSetName = "EscolaDataSet";
            this.escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgClasses
            // 
            this.dgClasses.AllowUserToAddRows = false;
            this.dgClasses.AllowUserToDeleteRows = false;
            this.dgClasses.AllowUserToResizeColumns = false;
            this.dgClasses.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgClasses.AutoGenerateColumns = false;
            this.dgClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.descricaoDataGridViewTextBoxColumn1});
            this.dgClasses.DataSource = this.bsClasse;
            this.dgClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgClasses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgClasses.Location = new System.Drawing.Point(3, 3);
            this.dgClasses.MultiSelect = false;
            this.dgClasses.Name = "dgClasses";
            this.dgClasses.ReadOnly = true;
            this.dgClasses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgClasses.RowTemplate.Height = 30;
            this.dgClasses.RowTemplate.ReadOnly = true;
            this.dgClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClasses.Size = new System.Drawing.Size(786, 374);
            this.dgClasses.TabIndex = 0;
            this.dgClasses.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClasses_RowEnter);
            // 
            // bsClasse
            // 
            this.bsClasse.DataMember = "Classe";
            this.bsClasse.DataSource = this.escolaDataSet;
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.dgDebugChamada);
            this.tabPageDebug.Controls.Add(this.dgDebugResponsavel);
            this.tabPageDebug.Controls.Add(this.dgDebugClasse);
            this.tabPageDebug.Controls.Add(this.dgDebugAluno);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(792, 615);
            this.tabPageDebug.TabIndex = 4;
            this.tabPageDebug.Text = "_debug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // dgDebugChamada
            // 
            this.dgDebugChamada.AutoGenerateColumns = false;
            this.dgDebugChamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDebugChamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.presenteDataGridViewCheckBoxColumn,
            this.nomeDataGridViewTextBoxColumn2,
            this.responsavelDataGridViewTextBoxColumn1,
            this.nomeResponsavelDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn1,
            this.classeDescricaoDataGridViewTextBoxColumn});
            this.dgDebugChamada.DataSource = this.bsChamada;
            this.dgDebugChamada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDebugChamada.Location = new System.Drawing.Point(3, 423);
            this.dgDebugChamada.Name = "dgDebugChamada";
            this.dgDebugChamada.Size = new System.Drawing.Size(786, 189);
            this.dgDebugChamada.TabIndex = 3;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            // 
            // presenteDataGridViewCheckBoxColumn
            // 
            this.presenteDataGridViewCheckBoxColumn.DataPropertyName = "Presente";
            this.presenteDataGridViewCheckBoxColumn.HeaderText = "Presente";
            this.presenteDataGridViewCheckBoxColumn.Name = "presenteDataGridViewCheckBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            // 
            // responsavelDataGridViewTextBoxColumn1
            // 
            this.responsavelDataGridViewTextBoxColumn1.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn1.HeaderText = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn1.Name = "responsavelDataGridViewTextBoxColumn1";
            // 
            // nomeResponsavelDataGridViewTextBoxColumn
            // 
            this.nomeResponsavelDataGridViewTextBoxColumn.DataPropertyName = "NomeResponsavel";
            this.nomeResponsavelDataGridViewTextBoxColumn.HeaderText = "NomeResponsavel";
            this.nomeResponsavelDataGridViewTextBoxColumn.Name = "nomeResponsavelDataGridViewTextBoxColumn";
            // 
            // classeDataGridViewTextBoxColumn1
            // 
            this.classeDataGridViewTextBoxColumn1.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn1.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn1.Name = "classeDataGridViewTextBoxColumn1";
            // 
            // classeDescricaoDataGridViewTextBoxColumn
            // 
            this.classeDescricaoDataGridViewTextBoxColumn.DataPropertyName = "ClasseDescricao";
            this.classeDescricaoDataGridViewTextBoxColumn.HeaderText = "ClasseDescricao";
            this.classeDescricaoDataGridViewTextBoxColumn.Name = "classeDescricaoDataGridViewTextBoxColumn";
            // 
            // bsChamada
            // 
            this.bsChamada.DataMember = "Chamada";
            this.bsChamada.DataSource = this.escolaDataSet;
            // 
            // dgDebugResponsavel
            // 
            this.dgDebugResponsavel.AutoGenerateColumns = false;
            this.dgDebugResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDebugResponsavel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nomeDataGridViewTextBoxColumn1});
            this.dgDebugResponsavel.DataSource = this.bsResponsavel;
            this.dgDebugResponsavel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgDebugResponsavel.Location = new System.Drawing.Point(3, 307);
            this.dgDebugResponsavel.Name = "dgDebugResponsavel";
            this.dgDebugResponsavel.Size = new System.Drawing.Size(786, 116);
            this.dgDebugResponsavel.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // bsResponsavel
            // 
            this.bsResponsavel.DataMember = "Responsavel";
            this.bsResponsavel.DataSource = this.escolaDataSet;
            // 
            // dgDebugClasse
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDebugClasse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgDebugClasse.AutoGenerateColumns = false;
            this.dgDebugClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDebugClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgDebugClasse.DataSource = this.bsClasse;
            this.dgDebugClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgDebugClasse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgDebugClasse.Location = new System.Drawing.Point(3, 140);
            this.dgDebugClasse.Name = "dgDebugClasse";
            this.dgDebugClasse.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDebugClasse.RowTemplate.Height = 30;
            this.dgDebugClasse.Size = new System.Drawing.Size(786, 167);
            this.dgDebugClasse.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // dgDebugAluno
            // 
            this.dgDebugAluno.AllowUserToAddRows = false;
            this.dgDebugAluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDebugAluno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgDebugAluno.AutoGenerateColumns = false;
            this.dgDebugAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDebugAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.responsavelDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn});
            this.dgDebugAluno.DataSource = this.bsAluno;
            this.dgDebugAluno.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgDebugAluno.Location = new System.Drawing.Point(3, 3);
            this.dgDebugAluno.Name = "dgDebugAluno";
            this.dgDebugAluno.ReadOnly = true;
            this.dgDebugAluno.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDebugAluno.RowTemplate.Height = 30;
            this.dgDebugAluno.Size = new System.Drawing.Size(786, 137);
            this.dgDebugAluno.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsavelDataGridViewTextBoxColumn
            // 
            this.responsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.HeaderText = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.Name = "responsavelDataGridViewTextBoxColumn";
            this.responsavelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsAluno
            // 
            this.bsAluno.DataMember = "Aluno";
            this.bsAluno.DataSource = this.escolaDataSet;
            // 
            // tabPageAlunosPorClasse
            // 
            this.tabPageAlunosPorClasse.Controls.Add(this.dgAlunosClasse);
            this.tabPageAlunosPorClasse.Controls.Add(this.panel1);
            this.tabPageAlunosPorClasse.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlunosPorClasse.Name = "tabPageAlunosPorClasse";
            this.tabPageAlunosPorClasse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlunosPorClasse.Size = new System.Drawing.Size(792, 615);
            this.tabPageAlunosPorClasse.TabIndex = 0;
            this.tabPageAlunosPorClasse.Text = "Chamada de classe";
            this.tabPageAlunosPorClasse.UseVisualStyleBackColor = true;
            // 
            // dgAlunosClasse
            // 
            this.dgAlunosClasse.AllowUserToAddRows = false;
            this.dgAlunosClasse.AllowUserToDeleteRows = false;
            this.dgAlunosClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunosClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAlunosClasse.Location = new System.Drawing.Point(3, 43);
            this.dgAlunosClasse.Name = "dgAlunosClasse";
            this.dgAlunosClasse.ReadOnly = true;
            this.dgAlunosClasse.Size = new System.Drawing.Size(786, 569);
            this.dgAlunosClasse.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ComboClasse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(438, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "label4";
            this.lblData.Paint += new System.Windows.Forms.PaintEventHandler(this.lblData_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // ComboClasse
            // 
            this.ComboClasse.DisplayMember = "Id";
            this.ComboClasse.Enabled = false;
            this.ComboClasse.FormattingEnabled = true;
            this.ComboClasse.Location = new System.Drawing.Point(52, 11);
            this.ComboClasse.Name = "ComboClasse";
            this.ComboClasse.Size = new System.Drawing.Size(325, 21);
            this.ComboClasse.TabIndex = 1;
            this.ComboClasse.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classe:";
            // 
            // tabPageResponsaveis
            // 
            this.tabPageResponsaveis.Controls.Add(this.dgResponsaveis);
            this.tabPageResponsaveis.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponsaveis.Name = "tabPageResponsaveis";
            this.tabPageResponsaveis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponsaveis.Size = new System.Drawing.Size(792, 615);
            this.tabPageResponsaveis.TabIndex = 2;
            this.tabPageResponsaveis.Text = "_Responsáveis";
            this.tabPageResponsaveis.UseVisualStyleBackColor = true;
            // 
            // dgResponsaveis
            // 
            this.dgResponsaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResponsaveis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResponsaveis.Location = new System.Drawing.Point(3, 3);
            this.dgResponsaveis.Name = "dgResponsaveis";
            this.dgResponsaveis.Size = new System.Drawing.Size(786, 609);
            this.dgResponsaveis.TabIndex = 0;
            // 
            // tabPageApp
            // 
            this.tabPageApp.Controls.Add(this.dgChamada);
            this.tabPageApp.Controls.Add(this.panel2);
            this.tabPageApp.Location = new System.Drawing.Point(4, 22);
            this.tabPageApp.Name = "tabPageApp";
            this.tabPageApp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApp.Size = new System.Drawing.Size(792, 615);
            this.tabPageApp.TabIndex = 3;
            this.tabPageApp.Text = "_simulação App";
            this.tabPageApp.UseVisualStyleBackColor = true;
            // 
            // dgChamada
            // 
            this.dgChamada.AllowUserToAddRows = false;
            this.dgChamada.AllowUserToDeleteRows = false;
            this.dgChamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChamada.Location = new System.Drawing.Point(3, 42);
            this.dgChamada.Name = "dgChamada";
            this.dgChamada.ReadOnly = true;
            this.dgChamada.Size = new System.Drawing.Size(786, 570);
            this.dgChamada.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 39);
            this.panel2.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(99, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Responsável:";
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // chamadaTableAdapter
            // 
            this.chamadaTableAdapter.ClearBeforeFill = true;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // chamadaPorClasseTableAdapter
            // 
            this.chamadaPorClasseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Classe Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 75;
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Classe";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            this.dataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn1.Width = 55;
            // 
            // alunoDataGridViewTextBoxColumn1
            // 
            this.alunoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alunoDataGridViewTextBoxColumn1.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn1.HeaderText = "Aluno Id";
            this.alunoDataGridViewTextBoxColumn1.Name = "alunoDataGridViewTextBoxColumn1";
            this.alunoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.alunoDataGridViewTextBoxColumn1.Width = 71;
            // 
            // nomeDataGridViewTextBoxColumn3
            // 
            this.nomeDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn3.Name = "nomeDataGridViewTextBoxColumn3";
            this.nomeDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // presenteDataGridViewCheckBoxColumn1
            // 
            this.presenteDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.presenteDataGridViewCheckBoxColumn1.DataPropertyName = "Presente";
            this.presenteDataGridViewCheckBoxColumn1.HeaderText = "Presente?";
            this.presenteDataGridViewCheckBoxColumn1.Name = "presenteDataGridViewCheckBoxColumn1";
            this.presenteDataGridViewCheckBoxColumn1.Width = 61;
            // 
            // responsavelDataGridViewTextBoxColumn2
            // 
            this.responsavelDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.responsavelDataGridViewTextBoxColumn2.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn2.HeaderText = "Responsável Id";
            this.responsavelDataGridViewTextBoxColumn2.Name = "responsavelDataGridViewTextBoxColumn2";
            this.responsavelDataGridViewTextBoxColumn2.ReadOnly = true;
            this.responsavelDataGridViewTextBoxColumn2.Width = 97;
            // 
            // nomeResponsavelDataGridViewTextBoxColumn1
            // 
            this.nomeResponsavelDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeResponsavelDataGridViewTextBoxColumn1.DataPropertyName = "NomeResponsavel";
            this.nomeResponsavelDataGridViewTextBoxColumn1.HeaderText = "Nome do Responsável";
            this.nomeResponsavelDataGridViewTextBoxColumn1.Name = "nomeResponsavelDataGridViewTextBoxColumn1";
            this.nomeResponsavelDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomeResponsavelDataGridViewTextBoxColumn1.Width = 128;
            // 
            // classeDataGridViewTextBoxColumn2
            // 
            this.classeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classeDataGridViewTextBoxColumn2.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn2.HeaderText = "Classe Id";
            this.classeDataGridViewTextBoxColumn2.Name = "classeDataGridViewTextBoxColumn2";
            this.classeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.classeDataGridViewTextBoxColumn2.Visible = false;
            this.classeDataGridViewTextBoxColumn2.Width = 69;
            // 
            // classeDescricaoDataGridViewTextBoxColumn1
            // 
            this.classeDescricaoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classeDescricaoDataGridViewTextBoxColumn1.DataPropertyName = "ClasseDescricao";
            this.classeDescricaoDataGridViewTextBoxColumn1.HeaderText = "Classe";
            this.classeDescricaoDataGridViewTextBoxColumn1.Name = "classeDescricaoDataGridViewTextBoxColumn1";
            this.classeDescricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.classeDescricaoDataGridViewTextBoxColumn1.Visible = false;
            this.classeDescricaoDataGridViewTextBoxColumn1.Width = 63;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Chamada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChamadaClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChamadaPorClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClasse)).EndInit();
            this.tabPageDebug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugChamada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChamada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebugAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAluno)).EndInit();
            this.tabPageAlunosPorClasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunosClasse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageResponsaveis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResponsaveis)).EndInit();
            this.tabPageApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChamada)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAlunosPorClasse;
        private System.Windows.Forms.DataGridView dgAlunosClasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageClasses;
        private System.Windows.Forms.TabPage tabPageResponsaveis;
        private System.Windows.Forms.ComboBox ComboClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageApp;
        private System.Windows.Forms.DataGridView dgClasses;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.DataGridView dgDebugAluno;
        private System.Windows.Forms.DataGridView dgDebugClasse;
        private System.Windows.Forms.DataGridView dgDebugResponsavel;
        private System.Windows.Forms.DataGridView dgDebugChamada;
        private System.Windows.Forms.DataGridView dgResponsaveis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgChamada;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgChamadaClasse;
        private EscolaDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private EscolaDataSetTableAdapters.ChamadaTableAdapter chamadaTableAdapter;
        private EscolaDataSetTableAdapters.ClasseTableAdapter classeTableAdapter;
        private EscolaDataSetTableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private System.Windows.Forms.BindingSource bsAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private EscolaDataSet escolaDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bsResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsClasse;
        private System.Windows.Forms.BindingSource bsChamada;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presenteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDescricaoDataGridViewTextBoxColumn;
        private EscolaDataSetTableAdapters.ChamadaTableAdapter chamadaPorClasseTableAdapter;
        private System.Windows.Forms.BindingSource bsChamadaPorClasse;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPadrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn presenteDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeResponsavelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDescricaoDataGridViewTextBoxColumn1;
    }
}

