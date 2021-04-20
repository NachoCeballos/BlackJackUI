using System;

namespace BlackJack_UI
{
    partial class JuegoWPF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnJugador1PedirC = new System.Windows.Forms.Button();
            this.btnJugador1MeQuedo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugador1PedirC
            // 
            this.btnJugador1PedirC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJugador1PedirC.Location = new System.Drawing.Point(11, 493);
            this.btnJugador1PedirC.Name = "btnJugador1PedirC";
            this.btnJugador1PedirC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnJugador1PedirC.Size = new System.Drawing.Size(75, 23);
            this.btnJugador1PedirC.TabIndex = 6;
            this.btnJugador1PedirC.Text = "Pedir Carta";
            this.btnJugador1PedirC.UseVisualStyleBackColor = true;
            this.btnJugador1PedirC.Click += new System.EventHandler(this.btnJugador1PedirC_Click);
            // 
            // btnJugador1MeQuedo
            // 
            this.btnJugador1MeQuedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJugador1MeQuedo.Location = new System.Drawing.Point(92, 493);
            this.btnJugador1MeQuedo.Name = "btnJugador1MeQuedo";
            this.btnJugador1MeQuedo.Size = new System.Drawing.Size(75, 23);
            this.btnJugador1MeQuedo.TabIndex = 7;
            this.btnJugador1MeQuedo.Text = "Me quedo";
            this.btnJugador1MeQuedo.UseVisualStyleBackColor = true;
            this.btnJugador1MeQuedo.Click += new System.EventHandler(this.btnJugador1MeQuedo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(871, 475);
            this.dataGridView1.TabIndex = 9;
            // 
            // JuegoWPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnJugador1PedirC);
            this.Controls.Add(this.btnJugador1MeQuedo);
            this.Name = "JuegoWPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJugador1PedirC;
        private System.Windows.Forms.Button btnJugador1MeQuedo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

