namespace GerenciamentoDeFuncionarios
{
    partial class FrmTelaInicial
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
            btnSouAdministrador = new Button();
            btnSouFuncionario = new Button();
            SuspendLayout();
            // 
            // btnSouAdministrador
            // 
            btnSouAdministrador.Location = new Point(268, 99);
            btnSouAdministrador.Name = "btnSouAdministrador";
            btnSouAdministrador.Size = new Size(252, 103);
            btnSouAdministrador.TabIndex = 0;
            btnSouAdministrador.Text = "Sou administrador";
            btnSouAdministrador.UseVisualStyleBackColor = true;
            btnSouAdministrador.Click += btnSouAdministrador_Click;
            // 
            // btnSouFuncionario
            // 
            btnSouFuncionario.Location = new Point(268, 234);
            btnSouFuncionario.Name = "btnSouFuncionario";
            btnSouFuncionario.Size = new Size(252, 103);
            btnSouFuncionario.TabIndex = 1;
            btnSouFuncionario.Text = "Sou funcionário";
            btnSouFuncionario.UseVisualStyleBackColor = true;
            btnSouFuncionario.Click += btnSouFuncionario_Click;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSouFuncionario);
            Controls.Add(btnSouAdministrador);
            Name = "FrmTelaInicial";
            Text = "Tela inicial";
            Load += FrmTelaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSouAdministrador;
        private Button btnSouFuncionario;
    }
}
