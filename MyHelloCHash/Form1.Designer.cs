namespace MyHelloCHash
{
    partial class FormMain
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
            this.btn_Greeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Greeting
            // 
            this.btn_Greeting.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Greeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Greeting.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Greeting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Greeting.Location = new System.Drawing.Point(39, 23);
            this.btn_Greeting.Name = "btn_Greeting";
            this.btn_Greeting.Size = new System.Drawing.Size(583, 378);
            this.btn_Greeting.TabIndex = 0;
            this.btn_Greeting.Text = "Welcome~";
            this.btn_Greeting.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 434);
            this.Controls.Add(this.btn_Greeting);
            this.Name = "FormMain";
            this.Text = "MyHelloCHash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Greeting;
    }
}

