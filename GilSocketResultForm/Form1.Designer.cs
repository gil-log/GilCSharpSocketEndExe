
namespace GilSocketResultForm
{
    partial class SocketResultForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.receiveData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendData = new System.Windows.Forms.Label();
            this.btnTwice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_html = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(88, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "딴 돈";
            // 
            // receiveData
            // 
            this.receiveData.AutoSize = true;
            this.receiveData.Location = new System.Drawing.Point(90, 71);
            this.receiveData.Name = "receiveData";
            this.receiveData.Size = new System.Drawing.Size(0, 12);
            this.receiveData.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(356, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "챙겨갈 돈";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sendData
            // 
            this.sendData.AutoSize = true;
            this.sendData.Location = new System.Drawing.Point(372, 71);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(0, 12);
            this.sendData.TabIndex = 4;
            // 
            // btnTwice
            // 
            this.btnTwice.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTwice.Font = new System.Drawing.Font("궁서체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTwice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTwice.Location = new System.Drawing.Point(137, 131);
            this.btnTwice.Name = "btnTwice";
            this.btnTwice.Size = new System.Drawing.Size(238, 38);
            this.btnTwice.TabIndex = 5;
            this.btnTwice.Text = "딴돈에 반만 가져가기";
            this.btnTwice.UseVisualStyleBackColor = false;
            this.btnTwice.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_html
            // 
            this.label_html.AutoSize = true;
            this.label_html.Location = new System.Drawing.Point(243, 105);
            this.label_html.Name = "label_html";
            this.label_html.Size = new System.Drawing.Size(11, 12);
            this.label_html.TabIndex = 7;
            this.label_html.Text = "0";
            // 
            // SocketResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 181);
            this.Controls.Add(this.label_html);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTwice);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.receiveData);
            this.Controls.Add(this.label1);
            this.Name = "SocketResultForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SocketResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label receiveData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sendData;
        private System.Windows.Forms.Button btnTwice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_html;
    }
}

