namespace ProjectFighter;

partial class FormFighter
{
    private System.ComponentModel.IContainer components = null;
    private PictureBox pictureBoxFighter;
    private Button buttonCreate;
    private Button buttonCheckBorders;
    private Button buttonLeft;
    private Button buttonRight;
    private Button buttonUp;
    private Button buttonDown;
    private Label labelSpeed;
    private Label labelWeight;
    private Label labelEngineCount;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pictureBoxFighter = new PictureBox();
        buttonCreate = new Button();
        buttonCheckBorders = new Button();
        buttonLeft = new Button();
        buttonRight = new Button();
        buttonUp = new Button();
        buttonDown = new Button();
        labelSpeed = new Label();
        labelWeight = new Label();
        labelEngineCount = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFighter).BeginInit();
        SuspendLayout();

        
        pictureBoxFighter.Dock = DockStyle.Fill;
        pictureBoxFighter.Location = new Point(0, 35);
        pictureBoxFighter.Name = "pictureBoxFighter";
        pictureBoxFighter.Size = new Size(900, 430);
        pictureBoxFighter.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBoxFighter.TabIndex = 0;
        pictureBoxFighter.TabStop = false;
        pictureBoxFighter.BackColor = Color.SkyBlue;

        
        buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        buttonCreate.Location = new Point(12, 438);
        buttonCreate.Name = "buttonCreate";
        buttonCreate.Size = new Size(100, 30);
        buttonCreate.TabIndex = 1;
        buttonCreate.Text = "Создать";
        buttonCreate.UseVisualStyleBackColor = true;
        buttonCreate.Click += ButtonCreateFighter_Click;

        
        buttonCheckBorders.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        buttonCheckBorders.Location = new Point(12, 5);
        buttonCheckBorders.Name = "buttonCheckBorders";
        buttonCheckBorders.Size = new Size(120, 30);
        buttonCheckBorders.TabIndex = 2;
        buttonCheckBorders.Text = "Проверка границ";
        buttonCheckBorders.UseVisualStyleBackColor = true;
        buttonCheckBorders.Click += ButtonCheckBorders_Click;

        
        buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonLeft.Location = new Point(740, 435);
        buttonLeft.Name = "buttonLeft";
        buttonLeft.Size = new Size(40, 40);
        buttonLeft.TabIndex = 3;
        buttonLeft.Text = "←";
        buttonLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        buttonLeft.UseVisualStyleBackColor = true;
        buttonLeft.Click += ButtonMove_Click;

        
        buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonRight.Location = new Point(825, 435);
        buttonRight.Name = "buttonRight";
        buttonRight.Size = new Size(40, 40);
        buttonRight.TabIndex = 4;
        buttonRight.Text = "→";
        buttonRight.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        buttonRight.UseVisualStyleBackColor = true;
        buttonRight.Click += ButtonMove_Click;

        
        buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonUp.Location = new Point(782, 390);
        buttonUp.Name = "buttonUp";
        buttonUp.Size = new Size(40, 40);
        buttonUp.TabIndex = 5;
        buttonUp.Text = "↑";
        buttonUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        buttonUp.UseVisualStyleBackColor = true;
        buttonUp.Click += ButtonMove_Click;

        
        buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonDown.Location = new Point(782, 480);
        buttonDown.Name = "buttonDown";
        buttonDown.Size = new Size(40, 40);
        buttonDown.TabIndex = 6;
        buttonDown.Text = "↓";
        buttonDown.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        buttonDown.UseVisualStyleBackColor = true;
        buttonDown.Click += ButtonMove_Click;

        
        labelSpeed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        labelSpeed.AutoSize = true;
        labelSpeed.Location = new Point(12, 475);
        labelSpeed.Name = "labelSpeed";
        labelSpeed.Size = new Size(0, 20);
        labelSpeed.TabIndex = 7;

        
        labelWeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        labelWeight.AutoSize = true;
        labelWeight.Location = new Point(12, 495);
        labelWeight.Name = "labelWeight";
        labelWeight.Size = new Size(0, 20);
        labelWeight.TabIndex = 8;

        
        labelEngineCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        labelEngineCount.AutoSize = true;
        labelEngineCount.Location = new Point(12, 515);
        labelEngineCount.Name = "labelEngineCount";
        labelEngineCount.Size = new Size(0, 20);
        labelEngineCount.TabIndex = 9;

        
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 500);
        Controls.Add(labelEngineCount);
        Controls.Add(labelWeight);
        Controls.Add(labelSpeed);
        Controls.Add(buttonDown);
        Controls.Add(buttonUp);
        Controls.Add(buttonRight);
        Controls.Add(buttonLeft);
        Controls.Add(buttonCheckBorders);
        Controls.Add(buttonCreate);
        Controls.Add(pictureBoxFighter);
        Name = "FormFighter";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Истребитель - отслеживание перемещения";
        ((System.ComponentModel.ISupportInitialize)pictureBoxFighter).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}