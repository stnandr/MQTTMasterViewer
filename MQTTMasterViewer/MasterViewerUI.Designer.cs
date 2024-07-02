namespace MQTTMasterViewer
{
    partial class MasterViewerUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterViewerUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            fillPanel = new Panel();
            bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuAboutButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunfiuExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuCOM800Button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuPocButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuBreakerButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).BeginInit();
            fillPanel.SuspendLayout();
            bunifuPanel1.SuspendLayout();
            bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            bunifuPictureBox1.AllowFocused = false;
            bunifuPictureBox1.Anchor = AnchorStyles.None;
            bunifuPictureBox1.AutoSizeHeight = true;
            bunifuPictureBox1.BorderRadius = 38;
            bunifuPictureBox1.Image = Properties.Resources.logo_white_GUI;
            bunifuPictureBox1.IsCircle = true;
            bunifuPictureBox1.Location = new Point(-1082, 11);
            bunifuPictureBox1.Name = "bunifuPictureBox1";
            bunifuPictureBox1.Size = new Size(77, 77);
            bunifuPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox1.TabIndex = 0;
            bunifuPictureBox1.TabStop = false;
            bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // fillPanel
            // 
            fillPanel.BackColor = Color.FromArgb(12, 7, 20);
            fillPanel.BorderStyle = BorderStyle.FixedSingle;
            fillPanel.Controls.Add(bunifuPanel1);
            fillPanel.Dock = DockStyle.Fill;
            fillPanel.Location = new Point(0, 0);
            fillPanel.Name = "fillPanel";
            fillPanel.Size = new Size(1029, 570);
            fillPanel.TabIndex = 1;
            fillPanel.MouseDown += mouse_Down;
            fillPanel.MouseMove += mouse_Move;
            // 
            // bunifuPanel1
            // 
            bunifuPanel1.BackgroundColor = Color.Transparent;
            bunifuPanel1.BackgroundImage = (Image)resources.GetObject("bunifuPanel1.BackgroundImage");
            bunifuPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel1.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuPanel1.BorderRadius = 3;
            bunifuPanel1.BorderThickness = 1;
            bunifuPanel1.Controls.Add(bunifuAboutButton);
            bunifuPanel1.Controls.Add(bunfiuExitButton);
            bunifuPanel1.Controls.Add(bunifuCOM800Button);
            bunifuPanel1.Controls.Add(bunifuPocButton);
            bunifuPanel1.Controls.Add(bunifuBreakerButton);
            bunifuPanel1.Controls.Add(bunifuPanel2);
            bunifuPanel1.Dock = DockStyle.Left;
            bunifuPanel1.Location = new Point(0, 0);
            bunifuPanel1.Name = "bunifuPanel1";
            bunifuPanel1.ShowBorders = true;
            bunifuPanel1.Size = new Size(251, 568);
            bunifuPanel1.TabIndex = 5;
            // 
            // bunifuAboutButton
            // 
            bunifuAboutButton.AllowAnimations = true;
            bunifuAboutButton.AllowMouseEffects = true;
            bunifuAboutButton.AllowToggling = false;
            bunifuAboutButton.AnimationSpeed = 200;
            bunifuAboutButton.AutoGenerateColors = false;
            bunifuAboutButton.AutoRoundBorders = false;
            bunifuAboutButton.AutoSizeLeftIcon = true;
            bunifuAboutButton.AutoSizeRightIcon = true;
            bunifuAboutButton.BackColor = Color.Transparent;
            bunifuAboutButton.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuAboutButton.BackgroundImage = (Image)resources.GetObject("bunifuAboutButton.BackgroundImage");
            bunifuAboutButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuAboutButton.ButtonText = "ABOUT";
            bunifuAboutButton.ButtonTextMarginLeft = 0;
            bunifuAboutButton.ColorContrastOnClick = 45;
            bunifuAboutButton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            bunifuAboutButton.CustomizableEdges = borderEdges1;
            bunifuAboutButton.DialogResult = DialogResult.None;
            bunifuAboutButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuAboutButton.DisabledFillColor = Color.Empty;
            bunifuAboutButton.DisabledForecolor = Color.Empty;
            bunifuAboutButton.Dock = DockStyle.Bottom;
            bunifuAboutButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuAboutButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            bunifuAboutButton.ForeColor = Color.White;
            bunifuAboutButton.IconLeft = null;
            bunifuAboutButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuAboutButton.IconLeftCursor = Cursors.Default;
            bunifuAboutButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuAboutButton.IconMarginLeft = 11;
            bunifuAboutButton.IconPadding = 10;
            bunifuAboutButton.IconRight = null;
            bunifuAboutButton.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuAboutButton.IconRightCursor = Cursors.Default;
            bunifuAboutButton.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuAboutButton.IconSize = 25;
            bunifuAboutButton.IdleBorderColor = Color.Empty;
            bunifuAboutButton.IdleBorderRadius = 0;
            bunifuAboutButton.IdleBorderThickness = 0;
            bunifuAboutButton.IdleFillColor = Color.Empty;
            bunifuAboutButton.IdleIconLeftImage = null;
            bunifuAboutButton.IdleIconRightImage = null;
            bunifuAboutButton.IndicateFocus = false;
            bunifuAboutButton.Location = new Point(0, 478);
            bunifuAboutButton.Name = "bunifuAboutButton";
            bunifuAboutButton.OnDisabledState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuAboutButton.OnDisabledState.BorderRadius = 1;
            bunifuAboutButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuAboutButton.OnDisabledState.BorderThickness = 1;
            bunifuAboutButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuAboutButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuAboutButton.OnDisabledState.IconLeftImage = null;
            bunifuAboutButton.OnDisabledState.IconRightImage = null;
            bunifuAboutButton.onHoverState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuAboutButton.onHoverState.BorderRadius = 1;
            bunifuAboutButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuAboutButton.onHoverState.BorderThickness = 1;
            bunifuAboutButton.onHoverState.FillColor = Color.FromArgb(137, 207, 240);
            bunifuAboutButton.onHoverState.ForeColor = Color.White;
            bunifuAboutButton.onHoverState.IconLeftImage = null;
            bunifuAboutButton.onHoverState.IconRightImage = null;
            bunifuAboutButton.OnIdleState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuAboutButton.OnIdleState.BorderRadius = 1;
            bunifuAboutButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuAboutButton.OnIdleState.BorderThickness = 1;
            bunifuAboutButton.OnIdleState.FillColor = Color.Transparent;
            bunifuAboutButton.OnIdleState.ForeColor = Color.White;
            bunifuAboutButton.OnIdleState.IconLeftImage = null;
            bunifuAboutButton.OnIdleState.IconRightImage = null;
            bunifuAboutButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuAboutButton.OnPressedState.BorderRadius = 1;
            bunifuAboutButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuAboutButton.OnPressedState.BorderThickness = 1;
            bunifuAboutButton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuAboutButton.OnPressedState.ForeColor = Color.White;
            bunifuAboutButton.OnPressedState.IconLeftImage = null;
            bunifuAboutButton.OnPressedState.IconRightImage = null;
            bunifuAboutButton.Size = new Size(251, 45);
            bunifuAboutButton.TabIndex = 9;
            bunifuAboutButton.TextAlign = ContentAlignment.MiddleCenter;
            bunifuAboutButton.TextAlignment = HorizontalAlignment.Center;
            bunifuAboutButton.TextMarginLeft = 0;
            bunifuAboutButton.TextPadding = new Padding(0);
            bunifuAboutButton.UseDefaultRadiusAndThickness = true;
            // 
            // bunfiuExitButton
            // 
            bunfiuExitButton.AllowAnimations = true;
            bunfiuExitButton.AllowMouseEffects = true;
            bunfiuExitButton.AllowToggling = false;
            bunfiuExitButton.AnimationSpeed = 200;
            bunfiuExitButton.AutoGenerateColors = false;
            bunfiuExitButton.AutoRoundBorders = false;
            bunfiuExitButton.AutoSizeLeftIcon = true;
            bunfiuExitButton.AutoSizeRightIcon = true;
            bunfiuExitButton.BackColor = Color.Transparent;
            bunfiuExitButton.BackColor1 = Color.FromArgb(51, 122, 183);
            bunfiuExitButton.BackgroundImage = (Image)resources.GetObject("bunfiuExitButton.BackgroundImage");
            bunfiuExitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunfiuExitButton.ButtonText = "EXIT";
            bunfiuExitButton.ButtonTextMarginLeft = 0;
            bunfiuExitButton.ColorContrastOnClick = 45;
            bunfiuExitButton.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            bunfiuExitButton.CustomizableEdges = borderEdges2;
            bunfiuExitButton.DialogResult = DialogResult.None;
            bunfiuExitButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunfiuExitButton.DisabledFillColor = Color.Empty;
            bunfiuExitButton.DisabledForecolor = Color.Empty;
            bunfiuExitButton.Dock = DockStyle.Bottom;
            bunfiuExitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunfiuExitButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            bunfiuExitButton.ForeColor = Color.White;
            bunfiuExitButton.IconLeft = null;
            bunfiuExitButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunfiuExitButton.IconLeftCursor = Cursors.Default;
            bunfiuExitButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunfiuExitButton.IconMarginLeft = 11;
            bunfiuExitButton.IconPadding = 10;
            bunfiuExitButton.IconRight = null;
            bunfiuExitButton.IconRightAlign = ContentAlignment.MiddleRight;
            bunfiuExitButton.IconRightCursor = Cursors.Default;
            bunfiuExitButton.IconRightPadding = new Padding(3, 3, 7, 3);
            bunfiuExitButton.IconSize = 25;
            bunfiuExitButton.IdleBorderColor = Color.Empty;
            bunfiuExitButton.IdleBorderRadius = 0;
            bunfiuExitButton.IdleBorderThickness = 0;
            bunfiuExitButton.IdleFillColor = Color.Empty;
            bunfiuExitButton.IdleIconLeftImage = null;
            bunfiuExitButton.IdleIconRightImage = null;
            bunfiuExitButton.IndicateFocus = false;
            bunfiuExitButton.Location = new Point(0, 523);
            bunfiuExitButton.Name = "bunfiuExitButton";
            bunfiuExitButton.OnDisabledState.BorderColor = Color.FromArgb(137, 207, 240);
            bunfiuExitButton.OnDisabledState.BorderRadius = 1;
            bunfiuExitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunfiuExitButton.OnDisabledState.BorderThickness = 1;
            bunfiuExitButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunfiuExitButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunfiuExitButton.OnDisabledState.IconLeftImage = null;
            bunfiuExitButton.OnDisabledState.IconRightImage = null;
            bunfiuExitButton.onHoverState.BorderColor = Color.FromArgb(137, 207, 240);
            bunfiuExitButton.onHoverState.BorderRadius = 1;
            bunfiuExitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunfiuExitButton.onHoverState.BorderThickness = 1;
            bunfiuExitButton.onHoverState.FillColor = Color.FromArgb(137, 207, 240);
            bunfiuExitButton.onHoverState.ForeColor = Color.White;
            bunfiuExitButton.onHoverState.IconLeftImage = null;
            bunfiuExitButton.onHoverState.IconRightImage = null;
            bunfiuExitButton.OnIdleState.BorderColor = Color.FromArgb(137, 207, 240);
            bunfiuExitButton.OnIdleState.BorderRadius = 1;
            bunfiuExitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunfiuExitButton.OnIdleState.BorderThickness = 1;
            bunfiuExitButton.OnIdleState.FillColor = Color.Transparent;
            bunfiuExitButton.OnIdleState.ForeColor = Color.White;
            bunfiuExitButton.OnIdleState.IconLeftImage = null;
            bunfiuExitButton.OnIdleState.IconRightImage = null;
            bunfiuExitButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunfiuExitButton.OnPressedState.BorderRadius = 1;
            bunfiuExitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunfiuExitButton.OnPressedState.BorderThickness = 1;
            bunfiuExitButton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunfiuExitButton.OnPressedState.ForeColor = Color.White;
            bunfiuExitButton.OnPressedState.IconLeftImage = null;
            bunfiuExitButton.OnPressedState.IconRightImage = null;
            bunfiuExitButton.Size = new Size(251, 45);
            bunfiuExitButton.TabIndex = 8;
            bunfiuExitButton.TextAlign = ContentAlignment.MiddleCenter;
            bunfiuExitButton.TextAlignment = HorizontalAlignment.Center;
            bunfiuExitButton.TextMarginLeft = 0;
            bunfiuExitButton.TextPadding = new Padding(0);
            bunfiuExitButton.UseDefaultRadiusAndThickness = true;
            bunfiuExitButton.Click += bunfiuExitButton_Click;
            // 
            // bunifuCOM800Button
            // 
            bunifuCOM800Button.AllowAnimations = true;
            bunifuCOM800Button.AllowMouseEffects = true;
            bunifuCOM800Button.AllowToggling = false;
            bunifuCOM800Button.AnimationSpeed = 200;
            bunifuCOM800Button.AutoGenerateColors = false;
            bunifuCOM800Button.AutoRoundBorders = false;
            bunifuCOM800Button.AutoSizeLeftIcon = true;
            bunifuCOM800Button.AutoSizeRightIcon = true;
            bunifuCOM800Button.BackColor = Color.Transparent;
            bunifuCOM800Button.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuCOM800Button.BackgroundImage = (Image)resources.GetObject("bunifuCOM800Button.BackgroundImage");
            bunifuCOM800Button.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuCOM800Button.ButtonText = "COM800";
            bunifuCOM800Button.ButtonTextMarginLeft = 0;
            bunifuCOM800Button.ColorContrastOnClick = 45;
            bunifuCOM800Button.ColorContrastOnHover = 45;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            bunifuCOM800Button.CustomizableEdges = borderEdges3;
            bunifuCOM800Button.DialogResult = DialogResult.None;
            bunifuCOM800Button.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuCOM800Button.DisabledFillColor = Color.Empty;
            bunifuCOM800Button.DisabledForecolor = Color.Empty;
            bunifuCOM800Button.Dock = DockStyle.Top;
            bunifuCOM800Button.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuCOM800Button.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            bunifuCOM800Button.ForeColor = Color.White;
            bunifuCOM800Button.IconLeft = null;
            bunifuCOM800Button.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuCOM800Button.IconLeftCursor = Cursors.Default;
            bunifuCOM800Button.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuCOM800Button.IconMarginLeft = 11;
            bunifuCOM800Button.IconPadding = 10;
            bunifuCOM800Button.IconRight = null;
            bunifuCOM800Button.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuCOM800Button.IconRightCursor = Cursors.Default;
            bunifuCOM800Button.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuCOM800Button.IconSize = 25;
            bunifuCOM800Button.IdleBorderColor = Color.Empty;
            bunifuCOM800Button.IdleBorderRadius = 0;
            bunifuCOM800Button.IdleBorderThickness = 0;
            bunifuCOM800Button.IdleFillColor = Color.Empty;
            bunifuCOM800Button.IdleIconLeftImage = null;
            bunifuCOM800Button.IdleIconRightImage = null;
            bunifuCOM800Button.IndicateFocus = false;
            bunifuCOM800Button.Location = new Point(0, 190);
            bunifuCOM800Button.Name = "bunifuCOM800Button";
            bunifuCOM800Button.OnDisabledState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuCOM800Button.OnDisabledState.BorderRadius = 1;
            bunifuCOM800Button.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuCOM800Button.OnDisabledState.BorderThickness = 1;
            bunifuCOM800Button.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuCOM800Button.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuCOM800Button.OnDisabledState.IconLeftImage = null;
            bunifuCOM800Button.OnDisabledState.IconRightImage = null;
            bunifuCOM800Button.onHoverState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuCOM800Button.onHoverState.BorderRadius = 1;
            bunifuCOM800Button.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuCOM800Button.onHoverState.BorderThickness = 1;
            bunifuCOM800Button.onHoverState.FillColor = Color.FromArgb(137, 207, 240);
            bunifuCOM800Button.onHoverState.ForeColor = Color.White;
            bunifuCOM800Button.onHoverState.IconLeftImage = null;
            bunifuCOM800Button.onHoverState.IconRightImage = null;
            bunifuCOM800Button.OnIdleState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuCOM800Button.OnIdleState.BorderRadius = 1;
            bunifuCOM800Button.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuCOM800Button.OnIdleState.BorderThickness = 1;
            bunifuCOM800Button.OnIdleState.FillColor = Color.Transparent;
            bunifuCOM800Button.OnIdleState.ForeColor = Color.White;
            bunifuCOM800Button.OnIdleState.IconLeftImage = null;
            bunifuCOM800Button.OnIdleState.IconRightImage = null;
            bunifuCOM800Button.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuCOM800Button.OnPressedState.BorderRadius = 1;
            bunifuCOM800Button.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuCOM800Button.OnPressedState.BorderThickness = 1;
            bunifuCOM800Button.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuCOM800Button.OnPressedState.ForeColor = Color.White;
            bunifuCOM800Button.OnPressedState.IconLeftImage = null;
            bunifuCOM800Button.OnPressedState.IconRightImage = null;
            bunifuCOM800Button.Size = new Size(251, 45);
            bunifuCOM800Button.TabIndex = 7;
            bunifuCOM800Button.TextAlign = ContentAlignment.MiddleCenter;
            bunifuCOM800Button.TextAlignment = HorizontalAlignment.Center;
            bunifuCOM800Button.TextMarginLeft = 0;
            bunifuCOM800Button.TextPadding = new Padding(0);
            bunifuCOM800Button.UseDefaultRadiusAndThickness = true;
            bunifuCOM800Button.Click += bunifuCOM800Button_Click;
            // 
            // bunifuPocButton
            // 
            bunifuPocButton.AllowAnimations = true;
            bunifuPocButton.AllowMouseEffects = true;
            bunifuPocButton.AllowToggling = false;
            bunifuPocButton.AnimationSpeed = 200;
            bunifuPocButton.AutoGenerateColors = false;
            bunifuPocButton.AutoRoundBorders = false;
            bunifuPocButton.AutoSizeLeftIcon = true;
            bunifuPocButton.AutoSizeRightIcon = true;
            bunifuPocButton.BackColor = Color.Transparent;
            bunifuPocButton.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuPocButton.BackgroundImage = (Image)resources.GetObject("bunifuPocButton.BackgroundImage");
            bunifuPocButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuPocButton.ButtonText = "POC1000";
            bunifuPocButton.ButtonTextMarginLeft = 0;
            bunifuPocButton.ColorContrastOnClick = 45;
            bunifuPocButton.ColorContrastOnHover = 45;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            bunifuPocButton.CustomizableEdges = borderEdges4;
            bunifuPocButton.DialogResult = DialogResult.None;
            bunifuPocButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuPocButton.DisabledFillColor = Color.Empty;
            bunifuPocButton.DisabledForecolor = Color.Empty;
            bunifuPocButton.Dock = DockStyle.Top;
            bunifuPocButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuPocButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            bunifuPocButton.ForeColor = Color.White;
            bunifuPocButton.IconLeft = null;
            bunifuPocButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuPocButton.IconLeftCursor = Cursors.Default;
            bunifuPocButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuPocButton.IconMarginLeft = 11;
            bunifuPocButton.IconPadding = 10;
            bunifuPocButton.IconRight = null;
            bunifuPocButton.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuPocButton.IconRightCursor = Cursors.Default;
            bunifuPocButton.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuPocButton.IconSize = 25;
            bunifuPocButton.IdleBorderColor = Color.Empty;
            bunifuPocButton.IdleBorderRadius = 0;
            bunifuPocButton.IdleBorderThickness = 0;
            bunifuPocButton.IdleFillColor = Color.Empty;
            bunifuPocButton.IdleIconLeftImage = null;
            bunifuPocButton.IdleIconRightImage = null;
            bunifuPocButton.IndicateFocus = false;
            bunifuPocButton.Location = new Point(0, 145);
            bunifuPocButton.Name = "bunifuPocButton";
            bunifuPocButton.OnDisabledState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuPocButton.OnDisabledState.BorderRadius = 1;
            bunifuPocButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuPocButton.OnDisabledState.BorderThickness = 1;
            bunifuPocButton.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            bunifuPocButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuPocButton.OnDisabledState.IconLeftImage = null;
            bunifuPocButton.OnDisabledState.IconRightImage = null;
            bunifuPocButton.onHoverState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuPocButton.onHoverState.BorderRadius = 1;
            bunifuPocButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuPocButton.onHoverState.BorderThickness = 1;
            bunifuPocButton.onHoverState.FillColor = Color.FromArgb(137, 207, 240);
            bunifuPocButton.onHoverState.ForeColor = Color.White;
            bunifuPocButton.onHoverState.IconLeftImage = null;
            bunifuPocButton.onHoverState.IconRightImage = null;
            bunifuPocButton.OnIdleState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuPocButton.OnIdleState.BorderRadius = 1;
            bunifuPocButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuPocButton.OnIdleState.BorderThickness = 1;
            bunifuPocButton.OnIdleState.FillColor = Color.Transparent;
            bunifuPocButton.OnIdleState.ForeColor = Color.White;
            bunifuPocButton.OnIdleState.IconLeftImage = null;
            bunifuPocButton.OnIdleState.IconRightImage = null;
            bunifuPocButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuPocButton.OnPressedState.BorderRadius = 1;
            bunifuPocButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuPocButton.OnPressedState.BorderThickness = 1;
            bunifuPocButton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuPocButton.OnPressedState.ForeColor = Color.White;
            bunifuPocButton.OnPressedState.IconLeftImage = null;
            bunifuPocButton.OnPressedState.IconRightImage = null;
            bunifuPocButton.Size = new Size(251, 45);
            bunifuPocButton.TabIndex = 6;
            bunifuPocButton.TextAlign = ContentAlignment.MiddleCenter;
            bunifuPocButton.TextAlignment = HorizontalAlignment.Center;
            bunifuPocButton.TextMarginLeft = 0;
            bunifuPocButton.TextPadding = new Padding(0);
            bunifuPocButton.UseDefaultRadiusAndThickness = true;
            bunifuPocButton.Click += bunifuPocButton_Click;
            // 
            // bunifuBreakerButton
            // 
            bunifuBreakerButton.AllowAnimations = true;
            bunifuBreakerButton.AllowMouseEffects = true;
            bunifuBreakerButton.AllowToggling = false;
            bunifuBreakerButton.AnimationSpeed = 200;
            bunifuBreakerButton.AutoGenerateColors = false;
            bunifuBreakerButton.AutoRoundBorders = false;
            bunifuBreakerButton.AutoSizeLeftIcon = true;
            bunifuBreakerButton.AutoSizeRightIcon = true;
            bunifuBreakerButton.BackColor = Color.Transparent;
            bunifuBreakerButton.BackColor1 = Color.FromArgb(51, 122, 183);
            bunifuBreakerButton.BackgroundImage = (Image)resources.GetObject("bunifuBreakerButton.BackgroundImage");
            bunifuBreakerButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuBreakerButton.ButtonText = "3VA";
            bunifuBreakerButton.ButtonTextMarginLeft = 0;
            bunifuBreakerButton.ColorContrastOnClick = 45;
            bunifuBreakerButton.ColorContrastOnHover = 45;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            bunifuBreakerButton.CustomizableEdges = borderEdges5;
            bunifuBreakerButton.DialogResult = DialogResult.None;
            bunifuBreakerButton.DisabledBorderColor = Color.FromArgb(191, 191, 191);
            bunifuBreakerButton.DisabledFillColor = Color.Empty;
            bunifuBreakerButton.DisabledForecolor = Color.Empty;
            bunifuBreakerButton.Dock = DockStyle.Top;
            bunifuBreakerButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            bunifuBreakerButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuBreakerButton.ForeColor = Color.Transparent;
            bunifuBreakerButton.IconLeft = null;
            bunifuBreakerButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            bunifuBreakerButton.IconLeftCursor = Cursors.Default;
            bunifuBreakerButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            bunifuBreakerButton.IconMarginLeft = 11;
            bunifuBreakerButton.IconPadding = 10;
            bunifuBreakerButton.IconRight = null;
            bunifuBreakerButton.IconRightAlign = ContentAlignment.MiddleRight;
            bunifuBreakerButton.IconRightCursor = Cursors.Default;
            bunifuBreakerButton.IconRightPadding = new Padding(3, 3, 7, 3);
            bunifuBreakerButton.IconSize = 25;
            bunifuBreakerButton.IdleBorderColor = Color.Empty;
            bunifuBreakerButton.IdleBorderRadius = 0;
            bunifuBreakerButton.IdleBorderThickness = 0;
            bunifuBreakerButton.IdleFillColor = Color.Empty;
            bunifuBreakerButton.IdleIconLeftImage = null;
            bunifuBreakerButton.IdleIconRightImage = null;
            bunifuBreakerButton.IndicateFocus = false;
            bunifuBreakerButton.Location = new Point(0, 100);
            bunifuBreakerButton.Name = "bunifuBreakerButton";
            bunifuBreakerButton.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
            bunifuBreakerButton.OnDisabledState.BorderRadius = 1;
            bunifuBreakerButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuBreakerButton.OnDisabledState.BorderThickness = 1;
            bunifuBreakerButton.OnDisabledState.FillColor = Color.Transparent;
            bunifuBreakerButton.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            bunifuBreakerButton.OnDisabledState.IconLeftImage = null;
            bunifuBreakerButton.OnDisabledState.IconRightImage = null;
            bunifuBreakerButton.onHoverState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuBreakerButton.onHoverState.BorderRadius = 1;
            bunifuBreakerButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuBreakerButton.onHoverState.BorderThickness = 1;
            bunifuBreakerButton.onHoverState.FillColor = Color.FromArgb(137, 207, 240);
            bunifuBreakerButton.onHoverState.ForeColor = Color.White;
            bunifuBreakerButton.onHoverState.IconLeftImage = null;
            bunifuBreakerButton.onHoverState.IconRightImage = null;
            bunifuBreakerButton.OnIdleState.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuBreakerButton.OnIdleState.BorderRadius = 1;
            bunifuBreakerButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            bunifuBreakerButton.OnIdleState.BorderThickness = 1;
            bunifuBreakerButton.OnIdleState.FillColor = Color.Transparent;
            bunifuBreakerButton.OnIdleState.ForeColor = Color.Transparent;
            bunifuBreakerButton.OnIdleState.IconLeftImage = null;
            bunifuBreakerButton.OnIdleState.IconRightImage = null;
            bunifuBreakerButton.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
            bunifuBreakerButton.OnPressedState.BorderRadius = 1;
            bunifuBreakerButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            bunifuBreakerButton.OnPressedState.BorderThickness = 1;
            bunifuBreakerButton.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
            bunifuBreakerButton.OnPressedState.ForeColor = Color.White;
            bunifuBreakerButton.OnPressedState.IconLeftImage = null;
            bunifuBreakerButton.OnPressedState.IconRightImage = null;
            bunifuBreakerButton.Size = new Size(251, 45);
            bunifuBreakerButton.TabIndex = 5;
            bunifuBreakerButton.TextAlign = ContentAlignment.MiddleCenter;
            bunifuBreakerButton.TextAlignment = HorizontalAlignment.Center;
            bunifuBreakerButton.TextMarginLeft = 0;
            bunifuBreakerButton.TextPadding = new Padding(0);
            bunifuBreakerButton.UseDefaultRadiusAndThickness = true;
            bunifuBreakerButton.Click += bunifuBreakerButton_Click;
            // 
            // bunifuPanel2
            // 
            bunifuPanel2.BackgroundColor = Color.Transparent;
            bunifuPanel2.BackgroundImage = (Image)resources.GetObject("bunifuPanel2.BackgroundImage");
            bunifuPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuPanel2.BorderColor = Color.FromArgb(137, 207, 240);
            bunifuPanel2.BorderRadius = 3;
            bunifuPanel2.BorderThickness = 1;
            bunifuPanel2.Controls.Add(bunifuPictureBox2);
            bunifuPanel2.Controls.Add(bunifuPictureBox1);
            bunifuPanel2.Dock = DockStyle.Top;
            bunifuPanel2.Location = new Point(0, 0);
            bunifuPanel2.Name = "bunifuPanel2";
            bunifuPanel2.ShowBorders = true;
            bunifuPanel2.Size = new Size(251, 100);
            bunifuPanel2.TabIndex = 0;
            bunifuPanel2.MouseDown += mouse_Down;
            bunifuPanel2.MouseMove += mouse_Move;
            // 
            // bunifuPictureBox2
            // 
            bunifuPictureBox2.AllowFocused = false;
            bunifuPictureBox2.Anchor = AnchorStyles.None;
            bunifuPictureBox2.AutoSizeHeight = true;
            bunifuPictureBox2.BorderRadius = 41;
            bunifuPictureBox2.Image = Properties.Resources.logo_white_GUI;
            bunifuPictureBox2.IsCircle = true;
            bunifuPictureBox2.Location = new Point(84, 12);
            bunifuPictureBox2.Name = "bunifuPictureBox2";
            bunifuPictureBox2.Size = new Size(82, 82);
            bunifuPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuPictureBox2.TabIndex = 1;
            bunifuPictureBox2.TabStop = false;
            bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // MasterViewerUI
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(fillPanel);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MasterViewerUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterViewerUI";
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox1).EndInit();
            fillPanel.ResumeLayout(false);
            bunifuPanel1.ResumeLayout(false);
            bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bunifuPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel fillPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuBreakerButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuPocButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuCOM800Button;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunfiuExitButton;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuAboutButton;
    }
}