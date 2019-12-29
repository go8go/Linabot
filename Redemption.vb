Imports System.Drawing.Drawing2D, System.Drawing.Text, System.Drawing
Imports System.ComponentModel

Public Enum MouseState As Byte
    None = 0
    Over = 1
    Down = 2
End Enum

Module Draw
    Public Function RoundRect(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim P As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
        P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        Return P
    End Function
    Public Function RoundRect(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer, ByVal Curve As Integer) As GraphicsPath
        Dim Rectangle As Rectangle = New Rectangle(X, Y, Width, Height)
        Dim P As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
        P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
        P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
        P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        Return P
    End Function
    Private Function ImageFromCode(ByRef str$) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(str)
        Dim ms As New IO.MemoryStream(imageBytes, 0, imageBytes.Length) : ms.Write(imageBytes, 0, imageBytes.Length)
        Dim i As Image = Image.FromStream(ms, True) : Return i
    End Function
    Public Function TiledTextureFromCode(ByVal str As String) As TextureBrush
        Return New TextureBrush(Draw.ImageFromCode(str), WrapMode.Tile)
    End Function
End Module

Public Class RedemptionButton
    Inherits Control
    Dim MouseState As MouseState = MouseState.None
    Enum HorizontalAlignment As Byte
        Left
        Center
        Right
    End Enum
    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Center
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            Invalidate()
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim curve As Integer = 5
        Dim b As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(b)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.TextRenderingHint = TextRenderingHint.AntiAlias
        MyBase.OnPaint(e)
        If Enabled Then
            g.Clear(BackColor)
            Select Case MouseState
                Case MouseState.None
                    Dim MainBody As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(55, 62, 70), Color.FromArgb(43, 44, 48), 90S)
                    g.FillPath(MainBody, Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
                    Dim GlossPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(93, 98, 104), Color.Transparent, 90S)
                    g.DrawPath(New Pen(GlossPen), Draw.RoundRect(New Rectangle(0, 1, Width - 1, Height - 1), curve + 1))
                Case MouseState.Over
                    Dim MainBody As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(72, 79, 87), Color.FromArgb(48, 51, 56), 90S)
                    g.FillPath(MainBody, Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
                    Dim GlossPen As New LinearGradientBrush(New Rectangle(1, 1, Width - 3, Height - 3), Color.FromArgb(119, 124, 130), Color.FromArgb(64, 67, 72), 90S)
                    g.DrawPath(New Pen(GlossPen), Draw.RoundRect(New Rectangle(1, 1, Width - 3, Height - 3), curve))
                Case MouseState.Down
                    Dim MainBody As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(43, 44, 48), Color.FromArgb(51, 54, 59), 90S)
                    g.FillPath(MainBody, Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
                    Dim GlossPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(55, 56, 60), Color.Transparent, 90S)
                    g.DrawPath(New Pen(GlossPen), Draw.RoundRect(New Rectangle(0, 1, Width - 1, Height - 1), curve + 1))
            End Select

            g.DrawPath(New Pen(Color.FromArgb(31, 36, 42)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
        Else

        End If


        Dim sf As New StringFormat()
        Select Case TextAlign
            Case HorizontalAlignment.Center
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(1, 2, Width - 1, Height - 1), sf)
                g.DrawString(Text, Font, Brushes.White, New Rectangle(0, 1, Width - 1, Height - 1), sf)
            Case HorizontalAlignment.Left
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(6, 2, Width - 1, Height - 1), sf)
                g.DrawString(Text, Font, Brushes.White, New Rectangle(5, 1, Width - 1, Height - 1), sf)
            Case HorizontalAlignment.Right
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(-3, 2, Width - 1, Height - 1), sf)
                g.DrawString(Text, Font, Brushes.White, New Rectangle(-4, 1, Width - 1, Height - 1), sf)
        End Select


        e.Graphics.DrawImage(b, New Point(0, 0))
        g.Dispose()
        b.Dispose()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        If Enabled Then
            MyBase.OnMouseEnter(e) : MouseState = MouseState.Over : Invalidate() : Cursor = Cursors.Hand
        End If
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        If Enabled Then
            MyBase.OnMouseDown(e) : MouseState = MouseState.Down : Invalidate() : Cursor = Cursors.Hand
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        If Enabled Then
            MyBase.OnMouseUp(e) : MouseState = MouseState.Over : Invalidate() : Cursor = Cursors.Hand
        End If
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        If Enabled Then
            MyBase.OnMouseLeave(e) : MouseState = MouseState.None : Invalidate() : Cursor = Cursors.Default
        End If
    End Sub
    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
End Class

Public Class RedemptionRoundButton
    Inherits Control
    Dim MouseState As MouseState = MouseState.None
    Enum HorizontalAlignment As Byte
        Left
        Center
        Right
    End Enum
    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Center
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            _TextAlign = value
            Invalidate()
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim curve As Integer = 13
        Dim b As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(b)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.TextRenderingHint = TextRenderingHint.AntiAlias
        MyBase.OnPaint(e)
        If Enabled Then
            g.Clear(BackColor)
            Select Case MouseState
                Case MouseState.None
                    Dim MainBody As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(131, 198, 240), Color.FromArgb(24, 121, 218), 90S)
                    g.FillPath(MainBody, Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
                    Dim GlossPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(145, 212, 254), Color.Transparent, 90S)
                    g.DrawPath(New Pen(GlossPen), Draw.RoundRect(New Rectangle(0, 1, Width - 1, Height - 2), curve + 1))
                Case MouseState.Over
                    Dim MainBody As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(150, 203, 235), Color.FromArgb(35, 135, 220), 90S)
                    g.FillPath(MainBody, Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
                    Dim GlossPen As New LinearGradientBrush(New Rectangle(1, 1, Width - 3, Height - 3), Color.FromArgb(173, 226, 255), Color.FromArgb(54, 155, 235), 90S)
                    g.DrawPath(New Pen(GlossPen), Draw.RoundRect(New Rectangle(1, 1, Width - 3, Height - 3), curve))
                Case MouseState.Down
                    Dim MainBody As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(30, 121, 210), Color.FromArgb(84, 172, 236), 90S)
                    g.FillPath(MainBody, Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
                    Dim GlossPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(54, 145, 234), Color.Transparent, 90S)
                    g.DrawPath(New Pen(GlossPen), Draw.RoundRect(New Rectangle(0, 1, Width - 1, Height - 1), curve + 1))
            End Select
            g.DrawPath(New Pen(Color.FromArgb(21, 38, 56)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
            g.FillRectangle(New SolidBrush(Parent.BackColor), New Rectangle(-1, -1, 2, 10))
            g.FillRectangle(New SolidBrush(Parent.BackColor), New Rectangle(-2, -1, 4, 9))
        Else

        End If


        Dim sf As New StringFormat()
        Select Case TextAlign
            Case HorizontalAlignment.Center
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(1, 2, Width - 1, Height - 1), sf)
                g.DrawString(Text, Font, Brushes.White, New Rectangle(0, 1, Width - 1, Height - 1), sf)
            Case HorizontalAlignment.Left
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(6, 2, Width - 1, Height - 1), sf)
                g.DrawString(Text, Font, Brushes.White, New Rectangle(5, 1, Width - 1, Height - 1), sf)
            Case HorizontalAlignment.Right
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(-3, 2, Width - 1, Height - 1), sf)
                g.DrawString(Text, Font, Brushes.White, New Rectangle(-4, 1, Width - 1, Height - 1), sf)
        End Select


        e.Graphics.DrawImage(b, New Point(0, 0))
        g.Dispose()
        b.Dispose()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        If Enabled Then
            MyBase.OnMouseEnter(e) : MouseState = MouseState.Over : Invalidate() : Cursor = Cursors.Hand
        End If
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        If Enabled Then
            MyBase.OnMouseDown(e) : MouseState = MouseState.Down : Invalidate() : Cursor = Cursors.Hand
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        If Enabled Then
            MyBase.OnMouseUp(e) : MouseState = MouseState.Over : Invalidate() : Cursor = Cursors.Hand
        End If
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        If Enabled Then
            MyBase.OnMouseLeave(e) : MouseState = MouseState.None : Invalidate() : Cursor = Cursors.Default
        End If
    End Sub
    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
End Class

Public Class RedemptionTextBox : Inherits Control
    Dim WithEvents txtbox As New TextBox
#Region " Control Help - Properties & Flicker Control "
    Private _UsePassword As Boolean = False
    Public Shadows Property UseSystemPasswordChar() As Boolean
        Get
            Return _UsePassword
        End Get
        Set(ByVal v As Boolean)
            txtbox.UseSystemPasswordChar = UseSystemPasswordChar
            _UsePassword = v
            Invalidate()
        End Set
    End Property
    Private _MaxCharacters As Integer = 32767
    Public Shadows Property MaxLength() As Integer
        Get
            Return _MaxCharacters
        End Get
        Set(ByVal v As Integer)
            _MaxCharacters = v
            txtbox.MaxLength = MaxLength
            Invalidate()
        End Set
    End Property
    Private _TextAlignment As HorizontalAlignment
    Public Shadows Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlignment
        End Get
        Set(ByVal v As HorizontalAlignment)
            _TextAlignment = v
            Invalidate()
        End Set
    End Property
    Private _MultiLine As Boolean = False
    Public Shadows Property MultiLine() As Boolean
        Get
            Return _MultiLine
        End Get
        Set(ByVal value As Boolean)
            _MultiLine = value
            txtbox.Multiline = value
            OnResize(EventArgs.Empty)
            Invalidate()
        End Set
    End Property


    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnBackColorChanged(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnForeColorChanged(ByVal e As System.EventArgs)
        MyBase.OnForeColorChanged(e)
        txtbox.ForeColor = ForeColor
        Invalidate()
    End Sub
    Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
        MyBase.OnFontChanged(e)
        txtbox.Font = Font
    End Sub
    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.OnGotFocus(e)
        txtbox.Focus()
    End Sub
    Private Sub TextChngTxtBox() Handles txtbox.TextChanged
        Text = txtbox.Text
    End Sub
    Private Sub TextChng() Handles MyBase.TextChanged
        txtbox.Text = Text
    End Sub
    Sub NewTextBox()
        With txtbox
            .Multiline = False
            .BackColor = Color.FromArgb(49, 50, 54)
            .ForeColor = ForeColor
            .Text = String.Empty
            .TextAlign = HorizontalAlignment.Center
            .BorderStyle = BorderStyle.None
            .Location = New Point(5, 4)
            .Font = New Font("Arial", 8.25F, FontStyle.Bold)
            .Size = New Size(Width - 10, Height - 11)
            .UseSystemPasswordChar = UseSystemPasswordChar
        End With

    End Sub
#End Region

    Sub New()
        MyBase.New()

        NewTextBox()
        Controls.Add(txtbox)

        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        Text = ""
        BackColor = Color.Transparent
        ForeColor = Color.White
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
        Size = New Size(135, 24)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim Curve As Integer = 4
        G.SmoothingMode = SmoothingMode.HighQuality

        With txtbox
            .TextAlign = TextAlign
            .UseSystemPasswordChar = UseSystemPasswordChar
        End With

        G.Clear(Color.Transparent)
        G.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            G.DrawPath(New Pen(GradientPen(i)), Draw.RoundRect(New Rectangle(i + 1, i + 1, Width - ((2 * i) + 3), Height - ((2 * i) + 3)), Curve))
        Next
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), Curve))

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Not MultiLine Then
            Dim TextBoxHeight As Integer = txtbox.Height
            txtbox.Location = New Point(10, (Height / 2) - (TextBoxHeight / 2) - 1)
            txtbox.Size = New Size(Width - 20, TextBoxHeight)
        Else
            Dim TextBoxHeight As Integer = txtbox.Height
            txtbox.Location = New Point(10, 10)
            txtbox.Size = New Size(Width - 20, Height - 20)
        End If
    End Sub
End Class

Public Class RedemptionProgressBar
    Inherits Control

#Region "Properties"
    Private val As Integer
    Public Property Value() As Integer
        Get
            Return val
        End Get
        Set(ByVal _value As Integer)
            If _value > max Then
                val = max
            ElseIf _value < 0 Then
                val = 0
            Else
                val = _value
            End If
            Invalidate()
        End Set
    End Property
    Private max As Integer
    Public Property Maximum() As Integer
        Get
            Return max
        End Get
        Set(ByVal _value As Integer)
            If _value < 1 Then
                max = 1
            Else
                max = _value
            End If

            If _value < val Then
                val = max
            End If

            Invalidate()
        End Set
    End Property
#End Region
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
    End Sub
    Sub New()
        max = 100
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim curve As Integer = 6
        Dim b As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(b)
        g.SmoothingMode = SmoothingMode.HighQuality
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim Fill As Integer = CInt((Width - 1) * (val / max))

        g.Clear(Color.Transparent)
        g.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            g.DrawPath(New Pen(GradientPen(i)), Draw.RoundRect(New Rectangle(i + 1, i + 1, Width - ((2 * i) + 3), Height - ((2 * i) + 3)), curve))
        Next

        If Fill > 4 Then
            g.FillPath(New SolidBrush(Color.FromArgb(80, 164, 234)), Draw.RoundRect(New Rectangle(0, 0, Fill, Height - 2), curve))
            Dim FillTexture As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 26, 127, 217), Color.Transparent)
            Dim Gloss As New LinearGradientBrush(New Rectangle(0, 0, Fill, Height - 2), Color.FromArgb(75, Color.White), Color.FromArgb(65, Color.Black), 90S)
            g.FillPath(Gloss, Draw.RoundRect(New Rectangle(0, 0, Fill, Height - 2), curve))
            g.FillPath(FillTexture, Draw.RoundRect(New Rectangle(0, 0, Fill, Height - 2), curve))
            Dim FillGradientBorder As New LinearGradientBrush(New Rectangle(0, 0, Fill, Height - 2), Color.FromArgb(183, 223, 249), Color.FromArgb(41, 141, 226), 90S)
            g.DrawPath(New Pen(FillGradientBorder), Draw.RoundRect(New Rectangle(1, 1, Fill - 2, Height - 4), curve))
            g.DrawPath(New Pen(Color.FromArgb(1, 44, 76)), Draw.RoundRect(New Rectangle(0, 0, Fill, Height - 2), curve))

        End If

        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        g.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), curve))
        g.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), curve))


        e.Graphics.DrawImage(b.Clone, 0, 0)
        g.Dispose() : b.Dispose()
    End Sub
End Class

Public Class RedemptionLabel : Inherits Control
    Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        ForeColor = Color.White
        BackColor = Color.FromArgb(51, 56, 60)
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub
    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e) : Invalidate()
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        MyBase.OnPaint(e)
        G.TextRenderingHint = TextRenderingHint.AntiAlias
        G.Clear(BackColor)
        G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(1, 1, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
        G.DrawString(Text, Font, New SolidBrush(ForeColor), New Rectangle(0, 0, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})


        e.Graphics.DrawImage(B, New Point(0, 0))
        G.Dispose() : B.Dispose()
    End Sub
End Class

Public Class RedemptionTabControl
    Inherits TabControl

    Enum HorizontalAlignments
        Left
        Center
        Right
    End Enum
    Private _Align As HorizontalAlignments = HorizontalAlignments.Left
    Public Property TextAlign() As HorizontalAlignments
        Get
            Return _Align
        End Get
        Set(ByVal value As HorizontalAlignments)
            _Align = value
            Invalidate()
        End Set
    End Property
    Private _BackgrounNoise As Boolean
    Public Property BackgroundNoise() As Boolean
        Get
            Return _BackgrounNoise
        End Get
        Set(ByVal value As Boolean)
            _BackgrounNoise = value
            Invalidate()
        End Set
    End Property

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        BackColor = Color.Transparent
        ItemSize = New Size(35, 100)
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Left
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim Curve As Integer = 6
        G.TextRenderingHint = TextRenderingHint.AntiAlias
        G.SmoothingMode = SmoothingMode.HighQuality
        Try : SelectedTab.BackColor = Color.FromArgb(47, 48, 52) : Catch : End Try
        G.Clear(Color.FromArgb(51, 56, 60))
        If BackgroundNoise Then
            Dim MatteNoise As TextureBrush = Draw.TiledTextureFromCode("iVBORw0KGgoAAAANSUhEUgAAAEYAAABGCAIAAAD+THXTAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAA2ZpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wTU09Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9tbS8iIHhtbG5zOnN0UmVmPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvc1R5cGUvUmVzb3VyY2VSZWYjIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDo1OEU1MkNDNjNCQjBFMjExQjY2NkFFNERBQzEzREJERiIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDpGQTIzMjhDQUIwM0IxMUUyOEY4NDk4NjlBRTkxQzE1QyIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDpGQTIzMjhDOUIwM0IxMUUyOEY4NDk4NjlBRTkxQzE1QyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ1M2IChXaW5kb3dzKSI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ4bXAuaWlkOjU4RTUyQ0M2M0JCMEUyMTFCNjY2QUU0REFDMTNEQkRGIiBzdFJlZjpkb2N1bWVudElEPSJ4bXAuZGlkOjU4RTUyQ0M2M0JCMEUyMTFCNjY2QUU0REFDMTNEQkRGIi8+IDwvcmRmOkRlc2NyaXB0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")
            G.FillRectangle(MatteNoise, New Rectangle(-1, -1, Width + 3, Height + 3))
            G.FillRectangle(New SolidBrush(Color.FromArgb(15, Color.White)), New Rectangle(-1, -1, Width + 3, Height + 3))
        End If
        G.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(ItemSize.Height - 1, 0, Width - ItemSize.Height - 1 - 1, Height - 1), Curve))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            G.DrawPath(New Pen(GradientPen(i)), Draw.RoundRect(New Rectangle(ItemSize.Height - 1 + i + 1, i + 1, Width - ItemSize.Height - 1 - ((2 * i) + 3), Height - ((2 * i) + 3)), Curve))
        Next
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(ItemSize.Height - 1, 0, Width - ItemSize.Height - 1 - 1, Height - 1), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(ItemSize.Height - 1, 0, Width - ItemSize.Height - 1 - 1, Height - 2), Curve))

        For i = 0 To TabCount - 1
            If i = SelectedIndex Then
                Dim OuterBorder As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 1, GetTabRect(i).Location.Y + 3), New Size(GetTabRect(i).Width - 7, GetTabRect(i).Height - 7))
                Dim InnerBorder As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 1, GetTabRect(i).Location.Y + 4), New Size(GetTabRect(i).Width - 7, GetTabRect(i).Height - 8))
                Dim MainBody As New LinearGradientBrush(OuterBorder, Color.FromArgb(72, 79, 87), Color.FromArgb(48, 51, 56), 90S)
                G.FillPath(MainBody, Draw.RoundRect(OuterBorder, Curve))
                Dim GlossPen As New LinearGradientBrush(OuterBorder, Color.FromArgb(119, 124, 130), Color.FromArgb(64, 67, 72), 90S)
                G.DrawPath(New Pen(GlossPen), Draw.RoundRect(InnerBorder, Curve))
                G.DrawPath(New Pen(Color.FromArgb(31, 36, 42)), Draw.RoundRect(OuterBorder, Curve))
            End If

            Select Case TextAlign
                Case HorizontalAlignments.Center
                    Dim TextRectangle As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 4, GetTabRect(i).Location.Y + 4), New Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7))
                    Dim TextShadow As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 3, GetTabRect(i).Location.Y + 5), New Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7))
                    G.DrawString(TabPages(i).Text, Font, New SolidBrush(Color.FromArgb(150, Color.Black)), TextShadow, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                    G.DrawString(TabPages(i).Text, Font, Brushes.White, TextRectangle, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                Case HorizontalAlignments.Left
                    Dim TextRectangle As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X + 5, GetTabRect(i).Location.Y + 4), New Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7))
                    Dim TextShadow As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X + 6, GetTabRect(i).Location.Y + 5), New Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7))
                    G.DrawString(TabPages(i).Text, Font, New SolidBrush(Color.FromArgb(150, Color.Black)), TextShadow, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                    G.DrawString(TabPages(i).Text, Font, Brushes.White, TextRectangle, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                Case HorizontalAlignments.Right
                    Dim TextRectangle As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 9, GetTabRect(i).Location.Y + 4), New Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7))
                    Dim TextShadow As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 8, GetTabRect(i).Location.Y + 5), New Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7))
                    G.DrawString(TabPages(i).Text, Font, New SolidBrush(Color.FromArgb(150, Color.Black)), TextShadow, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Far})
                    G.DrawString(TabPages(i).Text, Font, Brushes.White, TextRectangle, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Far})
            End Select
        Next
        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
End Class

Public Class RedemptionNumericUpDown : Inherits Control

#Region " Properties & Flicker Control "
    Private State As New MouseState
    Private X As Integer
    Private Y As Integer
    Private _Value As Long
    Private _Max As Long
    Private _Min As Long
    Private Typing As Boolean
    Public Property Value As Long
        Get
            Return _Value
        End Get
        Set(ByVal V As Long)
            If V <= _Max And V >= _Min Then _Value = V
            Invalidate()
        End Set
    End Property
    Public Property Maximum As Long
        Get
            Return _Max
        End Get
        Set(ByVal V As Long)
            If V > _Min Then _Max = V
            If _Value > _Max Then _Value = _Max
            Invalidate()
        End Set
    End Property
    Public Property Minimum As Long
        Get
            Return _Min
        End Get
        Set(ByVal V As Long)
            If V < _Max Then _Min = V
            If _Value < _Min Then _Value = _Min
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.Location.X
        Y = e.Location.Y
        Invalidate()
        If e.X < Width - 23 Then Cursor = Cursors.IBeam Else Cursor = Cursors.Default
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Me.Height = 26
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseClick(e)
        If X > Me.Width - 17 AndAlso X < Me.Width - 3 Then
            If Y < 13 Then
                If (Value + 1) <= _Max Then _Value += 1
            Else
                If (Value - 1) >= _Min Then _Value -= 1
            End If
        Else
            Typing = Not Typing
            Focus()
        End If
        Invalidate()
    End Sub
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        Try
            If Typing Then _Value = CStr(CStr(_Value) & e.KeyChar.ToString)
            If _Value > _Max Then _Value = _Max
        Catch ex As Exception : End Try
    End Sub
    Protected Overrides Sub OnKeyup(ByVal e As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyUp(e)
        If e.KeyCode = Keys.Up Then
            If (Value + 1) <= _Max Then _Value += 1
            Invalidate()
        ElseIf e.KeyCode = Keys.Down Then
            If (Value - 1) >= _Min Then _Value -= 1
        ElseIf e.KeyCode = Keys.Back Then
            Dim tmp As String = _Value.ToString()
            tmp = tmp.Remove(Convert.ToInt32(tmp.Length - 1))
            If (tmp.Length = 0) Then tmp = "0"
            _Value = Convert.ToInt32(tmp)
        End If
        Invalidate()
    End Sub
    Protected Sub DrawTriangle(ByVal Clr As Color, ByVal FirstPoint As Point, ByVal SecondPoint As Point, ByVal ThirdPoint As Point, ByVal G As Graphics)
        Dim points As New List(Of Point)()
        points.Add(FirstPoint)
        points.Add(SecondPoint)
        points.Add(ThirdPoint)
        G.FillPolygon(New SolidBrush(Clr), points.ToArray)
    End Sub
#End Region
    Sub New()
        _Max = 9999999
        _Min = 0
        Cursor = Cursors.IBeam
        SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        ForeColor = Color.White
        DoubleBuffered = True
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim Curve As Integer = 4
        G.Clear(BackColor)

        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.AntiAlias
        G.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            G.DrawPath(New Pen(GradientPen(i)), Draw.RoundRect(New Rectangle(i + 1, i + 1, Width - ((2 * i) + 3), Height - ((2 * i) + 3)), Curve))
        Next
        G.SetClip(Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), Curve))
        Dim ButtonBackground As New LinearGradientBrush(New Rectangle(Width - 17, 0, 17, Height - 2), Color.FromArgb(75, 78, 87), Color.FromArgb(50, 51, 55), 90S)
        G.FillRectangle(ButtonBackground, ButtonBackground.Rectangle)
        G.ResetClip()
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), Curve))
        DrawTriangle(Color.FromArgb(22, 23, 28), New Point(Width - 12, 8), New Point(Width - 6, 8), New Point(Width - 9, 5), G)
        DrawTriangle(Color.FromArgb(22, 23, 28), New Point(Width - 12, 17), New Point(Width - 6, 17), New Point(Width - 9, 20), G)
        G.SetClip(Draw.RoundRect(New Rectangle(Width - 17, 0, 17, Height - 2), Curve))
        G.DrawPath(New Pen(Color.FromArgb(82, 85, 92)), Draw.RoundRect(New Rectangle(1, 1, Width - 3, Height - 4), Curve))
        G.ResetClip()
        G.DrawLine(New Pen(Color.FromArgb(29, 37, 40)), New Point(Width - 17, 0), New Point(Width - 17, Height - 2))
        G.DrawLine(New Pen(Color.FromArgb(85, 92, 98)), New Point(Width - 16, 1), New Point(Width - 16, Height - 3))
        G.DrawLine(New Pen(Color.FromArgb(29, 37, 40)), New Point(Width - 17, Height / 2 - 1), New Point(Width - 1, Height / 2 - 1))
        G.DrawLine(New Pen(Color.FromArgb(85, 92, 98)), New Point(Width - 16, Height / 2), New Point(Width - 2, Height / 2))

        G.DrawString(Value, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Point(8, 8))
        G.DrawString(Value, Font, Brushes.White, New Point(7, 7))
        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
End Class

Public Class RedemptionComboBox : Inherits ComboBox
#Region " Control Help - Properties & Flicker Control "
    Private _StartIndex As Integer = 0
    Private Property StartIndex As Integer
        Get
            Return _StartIndex
        End Get
        Set(ByVal value As Integer)
            _StartIndex = value
            Try
                MyBase.SelectedIndex = value
            Catch
            End Try
            Invalidate()
        End Set
    End Property
    Sub ReplaceItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()
        Try
            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(59, 60, 64)), e.Bounds)
            Else
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(49, 50, 54)), e.Bounds)
            End If
            Using b As New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), e.Font, b, New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height))
            End Using
        Catch
        End Try
    End Sub
    Protected Sub DrawTriangle(ByVal Clr As Color, ByVal FirstPoint As Point, ByVal SecondPoint As Point, ByVal ThirdPoint As Point, ByVal G As Graphics)
        Dim points As New List(Of Point)()
        points.Add(FirstPoint)
        points.Add(SecondPoint)
        points.Add(ThirdPoint)
        G.FillPolygon(New SolidBrush(Clr), points.ToArray)
    End Sub

#End Region

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        BackColor = Color.Transparent
        ForeColor = Color.FromArgb(182, 179, 171)
        DropDownStyle = ComboBoxStyle.DropDownList
        StartIndex = 0
        ItemHeight = 18
        DoubleBuffered = True
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 26
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim Curve As Integer = 4
        G.Clear(BackColor)

        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = TextRenderingHint.AntiAlias
        G.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))

        Dim BodyGradient As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(57, 62, 68), Color.FromArgb(42, 43, 47), 90S)
        G.FillPath(BodyGradient, Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))


        G.SetClip(Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), Curve))
        Dim ButtonBackground As New LinearGradientBrush(New Rectangle(Width - 17, 0, 17, Height - 2), Color.FromArgb(75, 78, 87), Color.FromArgb(50, 51, 55), 90S)
        G.FillRectangle(ButtonBackground, ButtonBackground.Rectangle)
        G.ResetClip()


        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 1, Width - 1, Height - 2), Color.FromArgb(92, 97, 103), Color.Transparent, 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 1, Width - 1, Height - 2), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))


        DrawTriangle(Color.FromArgb(22, 23, 28), New Point(Width - 12, 8), New Point(Width - 6, 8), New Point(Width - 9, 5), G)
        DrawTriangle(Color.FromArgb(22, 23, 28), New Point(Width - 12, 14), New Point(Width - 6, 14), New Point(Width - 9, 17), G)
        G.SetClip(Draw.RoundRect(New Rectangle(Width - 17, 0, 17, Height), Curve))
        Dim ButtonPen As New LinearGradientBrush(New Rectangle(1, 1, Width - 3, Height - 3), Color.FromArgb(82, 85, 92), Color.FromArgb(66, 67, 72), 90S)
        G.DrawPath(New Pen(ButtonPen), Draw.RoundRect(New Rectangle(1, 1, Width - 3, Height - 3), Curve))
        G.ResetClip()
        G.DrawLine(New Pen(Color.FromArgb(29, 37, 40)), New Point(Width - 17, 0), New Point(Width - 17, Height - 2))
        G.DrawLine(New Pen(Color.FromArgb(85, 92, 98)), New Point(Width - 16, 1), New Point(Width - 16, Height - 3))

        Try
            G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(16, 20, 21)), New Rectangle(7, 0, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
            G.DrawString(Text, Font, New SolidBrush(Color.White), New Rectangle(7, 1, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
        Catch
        End Try

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
End Class

<DefaultEvent("CheckedChanged")> Public Class RedemptionCheckBox : Inherits Control

#Region " Control Help - MouseState & Flicker Control"
    Private State As MouseState = MouseState.None
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Width = CreateGraphics().MeasureString(Text, Font).Width + (2 * 3) + Height
        Invalidate()
    End Sub
    Private _Checked As Boolean
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Height = 19
    End Sub
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub
    Event CheckedChanged(ByVal sender As Object)
#End Region

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        BackColor = Color.Transparent
        ForeColor = Color.White
        Size = New Size(147, 17)
        DoubleBuffered = True
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim CheckBoxRectangle As New Rectangle(0, 0, Height - 1, Height - 1)
        Dim Curve As Integer = 1

        G.Clear(BackColor)

        G.Clear(Color.Transparent)
        G.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(0, 0, Height - 1, Height - 1), Curve))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            G.DrawPath(New Pen(GradientPen(i)), Draw.RoundRect(New Rectangle(i + 1, i + 1, Height - ((2 * i) + 3), Height - ((2 * i) + 3)), Curve))
        Next
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Height - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 0, Height - 2, Height - 1), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Height - 2, Height - 2), Curve))


        If Checked Then
            Dim chkPoly As Rectangle = New Rectangle(CheckBoxRectangle.X + CheckBoxRectangle.Width / 4, CheckBoxRectangle.Y + CheckBoxRectangle.Height / 4, CheckBoxRectangle.Width \ 2, CheckBoxRectangle.Height \ 2)
            Dim Poly() As Point = {New Point(chkPoly.X + 1, chkPoly.Y + chkPoly.Height \ 2), New Point(chkPoly.X + chkPoly.Width \ 2, chkPoly.Y + chkPoly.Height - 1), New Point(chkPoly.X + chkPoly.Width, chkPoly.Y)}
            For i = 0 To Poly.Length - 2 : G.DrawLine(New Pen(Color.White, 2), Poly(i), Poly(i + 1)) : Next
        End If

        G.DrawString(Text, Font, New SolidBrush(ForeColor), New Point(21, 3), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()

    End Sub

End Class

<DefaultEvent("CheckedChanged")> Public Class RedemptionRadioButton : Inherits Control

#Region " Control Help - MouseState & Flicker Control"
    Private R1 As Rectangle
    Private G1 As LinearGradientBrush

    Private State As MouseState = MouseState.None
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Height = 19
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Width = CreateGraphics().MeasureString(Text, Font).Width + (2 * 3) + Height
        Invalidate()
    End Sub
    Private _Checked As Boolean
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            InvalidateControls()
            RaiseEvent CheckedChanged(Me)
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        If Not _Checked Then Checked = True
        MyBase.OnClick(e)
    End Sub
    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        InvalidateControls()
    End Sub
    Private Sub InvalidateControls()
        Try
            If Not IsHandleCreated OrElse Not Checked Then Return
            For Each C As Control In Parent.Controls
                If C IsNot Me AndAlso TypeOf C Is RedemptionRadioButton Then
                    DirectCast(C, RedemptionRadioButton).Checked = False
                End If
            Next
        Catch : End Try
    End Sub
#End Region

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        ForeColor = Color.White
        DoubleBuffered = True
        Size = New Size(177, 17)
        Font = New Font("Arial", 8.25F, FontStyle.Bold)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim RadioBtnRectangle = New Rectangle(0, 0, Height - 1, Height - 1)

        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        G.Clear(BackColor)

        G.Clear(Color.Transparent)
        G.FillEllipse(New SolidBrush(Color.FromArgb(49, 50, 54)), New Rectangle(0, 0, Height - 1, Height - 1))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            G.DrawEllipse(New Pen(GradientPen(i)), New Rectangle(i + 1, i + 1, Height - ((2 * i) + 3), Height - ((2 * i) + 3)))
        Next
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Height - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawEllipse(New Pen(BorderPen), New Rectangle(0, 0, Height - 2, Height - 1))
        G.DrawEllipse(New Pen(Color.FromArgb(32, 33, 37)), New Rectangle(0, 0, Height - 2, Height - 2))



        If Checked Then
            G.FillEllipse(New SolidBrush(Color.White), New Rectangle(5, 5, Height - 12, Height - 12))
        End If

        G.DrawString(Text, Font, New SolidBrush(ForeColor), New Point(21, 3), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near})

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()
    End Sub

End Class

<DefaultEvent("CheckedChanged")> Public Class RedemptionToggle : Inherits Control

#Region " Control Help - MouseState & Flicker Control"
    Private State As MouseState = MouseState.None
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Private _Checked As Boolean
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Size = New Size(60, 26)
    End Sub
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub
    Event CheckedChanged(ByVal sender As Object)
#End Region

    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Size = New Size(60, 26)
        BackColor = Color.Transparent
        ForeColor = Color.White
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        G.SmoothingMode = SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim Curve As Integer = 4

        G.Clear(BackColor)

        G.Clear(Color.Transparent)
        G.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            G.DrawPath(New Pen(GradientPen(i)), Draw.RoundRect(New Rectangle(i + 1, i + 1, Width - ((2 * i) + 3), Height - ((2 * i) + 3)), Curve))
        Next
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 3), Curve))

        Select Case Checked
            Case False
                Dim CheckedBody As New LinearGradientBrush(New Rectangle(0, 0, 30, Height - 3), Color.FromArgb(72, 79, 87), Color.FromArgb(48, 52, 55), 90S)
                G.FillPath(CheckedBody, Draw.RoundRect(New Rectangle(0, 0, 30, Height - 3), Curve))
                Dim CheckedBorderPen As New LinearGradientBrush(New Rectangle(0, 0, 30, Height - 3), Color.FromArgb(29, 34, 40), Color.FromArgb(33, 34, 38), 90S)
                G.DrawPath(New Pen(CheckedBorderPen), Draw.RoundRect(New Rectangle(0, 0, 30, Height - 3), Curve))
                Dim CheckedBorderHighlight As New LinearGradientBrush(New Rectangle(1, 1, 28, Height - 5), Color.FromArgb(118, 123, 129), Color.FromArgb(66, 67, 71), 90S)
                G.DrawPath(New Pen(CheckedBorderHighlight), Draw.RoundRect(New Rectangle(1, 1, 28, Height - 5), Curve))
                For i As Integer = 0 To 2
                    G.DrawLine(New Pen(Color.FromArgb(82, 86, 95)), New Point(7, 7 + (i * 4)), New Point(22, 7 + (i * 4)))
                    G.DrawLine(New Pen(Color.FromArgb(47, 50, 57)), New Point(7, 7 + (i * 4) + 1), New Point(22, 7 + (i * 4) + 1))
                Next
            Case True
                Dim CheckedBody As New LinearGradientBrush(New Rectangle(29, 0, 30, Height - 3), Color.FromArgb(145, 204, 238), Color.FromArgb(35, 137, 222), 90S)
                G.FillPath(CheckedBody, Draw.RoundRect(New Rectangle(29, 0, 30, Height - 3), Curve))
                Dim CheckedBorderPen As New LinearGradientBrush(New Rectangle(29, 0, 30, Height - 3), Color.FromArgb(21, 37, 52), Color.FromArgb(18, 37, 54), 90S)
                G.DrawPath(New Pen(CheckedBorderPen), Draw.RoundRect(New Rectangle(29, 0, 30, Height - 3), Curve))
                Dim CheckedBorderHighlight As New LinearGradientBrush(New Rectangle(30, 1, 28, Height - 5), Color.FromArgb(169, 228, 255), Color.FromArgb(53, 155, 240), 90S)
                G.DrawPath(New Pen(CheckedBorderHighlight), Draw.RoundRect(New Rectangle(30, 1, 28, Height - 5), Curve))
                For i As Integer = 0 To 2
                    G.DrawLine(New Pen(Color.FromArgb(109, 188, 244)), New Point(36, 7 + (i * 4)), New Point(51, 7 + (i * 4)))
                    G.DrawLine(New Pen(Color.FromArgb(40, 123, 199)), New Point(36, 7 + (i * 4) + 1), New Point(51, 7 + (i * 4) + 1))
                Next
        End Select
        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose() : B.Dispose()

    End Sub

End Class

Public Class RedemptionListBox : Inherits ListBox
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        DoubleBuffered = True
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ForeColor = Color.White
        BackColor = Color.FromArgb(47, 48, 52)
        BorderStyle = Windows.Forms.BorderStyle.None
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        Dim Curve As Integer = 5
        MyBase.OnPaint(e)
        G.Clear(Color.Transparent)
        G.FillPath(New SolidBrush(Color.FromArgb(49, 50, 54)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))
        Dim GradientPen As Color() = {Color.FromArgb(43, 44, 48), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), Color.FromArgb(46, 47, 51), Color.FromArgb(47, 48, 52), Color.FromArgb(48, 49, 53)}
        For i As Integer = 0 To 5
            G.DrawPath(New Pen(GradientPen(i)), Draw.RoundRect(New Rectangle(i + 1, i + 1, Width - ((2 * i) + 3), Height - ((2 * i) + 3)), Curve))
        Next
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 1), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), Curve))

    End Sub
    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        Dim G As Graphics = e.Graphics
        Dim Curve As Integer = 5
        G.TextRenderingHint = TextRenderingHint.AntiAlias
        G.SmoothingMode = SmoothingMode.HighQuality
        G.SetClip(Draw.RoundRect(New Rectangle(0, 0, Width, Height), Curve))
        G.FillRectangle(New SolidBrush(BackColor), New Rectangle(e.Bounds.X, e.Bounds.Y - 1, e.Bounds.Width, e.Bounds.Height + 3))

        If e.State.ToString().Contains("Selected,") Then
            Dim MainBody As New LinearGradientBrush(New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height), Color.FromArgb(55, 62, 70), Color.FromArgb(43, 44, 48), 90S)
            G.FillRectangle(MainBody, New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height))
            Dim GlossPen As New LinearGradientBrush(New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), Color.FromArgb(100, 93, 98, 104), Color.Transparent, 90S)
            G.DrawRectangle(New Pen(GlossPen), New Rectangle(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height))

        Else
            G.FillRectangle(New SolidBrush(BackColor), e.Bounds)
        End If

        Try
            G.DrawString(Items(e.Index).ToString(), Font, New SolidBrush(Color.FromArgb(100, Color.Black)), New Rectangle(e.Bounds.X + 4, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
            G.DrawString(Items(e.Index).ToString(), Font, New SolidBrush(ForeColor), New Rectangle(e.Bounds.X + 3, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
        Catch : End Try
        Dim BorderPen As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Transparent, Color.FromArgb(87, 88, 92), 90S)
        G.DrawPath(New Pen(BorderPen), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 2), Curve))
        G.DrawPath(New Pen(Color.FromArgb(32, 33, 37)), Draw.RoundRect(New Rectangle(0, 0, Width - 1, Height - 3), Curve))
    End Sub
End Class

Public Class RedemptionForm : Inherits ContainerControl
#Region " Control Help - Movement & Flicker Control "
    Private TransparentColor As Color = Color.Fuchsia
    Private MouseP As Point = New Point(0, 0)
    Private Cap As Boolean = False
    Private MoveHeight As Integer
    Private pos As Integer = 0
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left And New Rectangle(0, 0, Width, MoveHeight).Contains(e.Location) Then
            Cap = True : MouseP = e.Location
        End If
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If Cap Then
            Parent.Location = MousePosition - MouseP
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e) : Cap = False
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.ParentForm.FormBorderStyle = FormBorderStyle.None
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        ParentForm.FindForm().TransparencyKey = TransparentColor
    End Sub

    Private _BackgroundNoise As Boolean = True
    Public Property BackgroundNoise() As Boolean
        Get
            Return _BackgroundNoise
        End Get
        Set(ByVal value As Boolean)
            _BackgroundNoise = value
            Invalidate()
        End Set
    End Property


#End Region

    Sub New()
        MyBase.New()
        Dock = DockStyle.Fill
        MoveHeight = 29
        Font = New Font("Verdana", 8.25F)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As Bitmap = New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim ClientRectangle As Rectangle = New Rectangle(0, 0, Width - 1, Height - 1)
        MyBase.OnPaint(e)
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        'G.FillRectangle(MatteNoise, ClientRectangle)
        G.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.White)), New Rectangle(0, 0, Width - 1, 28))
        G.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.White)), New Rectangle(0, 28, 6, Height - 35))
        G.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.White)), New Rectangle(Width - 7, 28, 7, Height - 35))
        G.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.White)), New Rectangle(0, Height - 7, Width - 1, 7))
        G.FillRectangle(New SolidBrush(Color.FromArgb(15, Color.White)), New Rectangle(6, 28, Width - 13, Height - 35))
        G.DrawLine(New Pen(Color.FromArgb(44, 45, 48)), New Point(6, 29), New Point(Width - 7, 29))
        G.DrawLine(New Pen(Color.FromArgb(37, 38, 40)), New Point(6, 30), New Point(Width - 7, 30))
        G.DrawLine(New Pen(Color.FromArgb(75, 60, 61, 62)), New Point(6, 31), New Point(Width - 7, 31))
        G.DrawLine(New Pen(Color.FromArgb(56, 57, 60)), New Point(5, 31), New Point(5, Height - 7))
        G.DrawLine(New Pen(Color.FromArgb(77, 78, 79)), New Point(6, 31), New Point(6, Height - 7))
        G.DrawLine(New Pen(Color.FromArgb(56, 57, 60)), New Point(Width - 7, 31), New Point(Width - 7, Height - 7))
        G.DrawLine(New Pen(Color.FromArgb(77, 78, 79)), New Point(Width - 8, 31), New Point(Width - 8, Height - 7))
        G.DrawLine(New Pen(Color.FromArgb(63, 64, 65)), New Point(6, Height - 8), New Point(Width - 7, Height - 8))
        G.DrawLine(New Pen(Color.FromArgb(63, 63, 63)), New Point(5, Height - 7), New Point(Width - 6, Height - 7))
        G.DrawLine(New Pen(Color.FromArgb(85, 86, 88)), New Point(0, 1), New Point(Width - 1, 1))
        G.DrawRectangle(New Pen(Color.FromArgb(21, 23, 25)), ClientRectangle)

        Dim ColorList As Color() = {Color.FromArgb(200, 34, 36, 39), Color.FromArgb(200, 5, 185, 238), Color.FromArgb(200, 34, 36, 39)}
        Dim PointList As Single() = {0 / 2, 1 / 2, 2 / 2}
        Dim AccentBrush As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.Black, Color.White, 90S)
        Dim AccentBlend As New ColorBlend With {.Colors = ColorList, .Positions = PointList}
        AccentBrush.InterpolationColors = AccentBlend
        G.DrawRectangle(New Pen(AccentBrush), New Rectangle(0, 0, Width - 1, Height - 1))

        Dim TextFormat As New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center}
        G.DrawString(Text, Font, New SolidBrush(Color.FromArgb(200, Color.Black)), New Rectangle(8, 1, Width - 1, 28), TextFormat)
        G.DrawString(Text, Font, New SolidBrush(ForeColor), New Rectangle(8, 2, Width - 1, 28), TextFormat)


        e.Graphics.DrawImage(B, New Point(0, 0))
        G.Dispose() : B.Dispose()
    End Sub

End Class

Public Class RedemptionControlBox : Inherits Control

    Sub New()
        MyBase.New()
        DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        ForeColor = Color.White
        BackColor = Color.Transparent
        Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(60, 25)
    End Sub
    Enum ButtonHover
        Minimize
        Maximize
        Close
        None
    End Enum
    Dim ButtonState As ButtonHover = ButtonHover.None
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Dim X As Integer = e.Location.X
        Dim Y As Integer = e.Location.Y
        If Y > 0 AndAlso Y < (Height - 2) Then
            If X > 0 AndAlso X < 30 Then
                ButtonState = ButtonHover.Minimize
            ElseIf X > 31 AndAlso X < Width Then
                ButtonState = ButtonHover.Close
            Else
                ButtonState = ButtonHover.None
            End If
        Else
            ButtonState = ButtonHover.None
        End If
        Invalidate()
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        MyBase.OnPaint(e)

        G.Clear(BackColor)
        Dim ButtonFont As New Font("Marlett", 10.0F)
        G.DrawString("r", ButtonFont, New SolidBrush(Color.FromArgb(200, 200, 200)), New Point(Width - 16, 7), New StringFormat With {.Alignment = StringAlignment.Center})
        G.DrawString("0", ButtonFont, New SolidBrush(Color.FromArgb(200, 200, 200)), New Point(20, 7), New StringFormat With {.Alignment = StringAlignment.Center})

        Select Case ButtonState
            Case ButtonHover.Minimize
                G.DrawString("0", ButtonFont, New SolidBrush(Color.White), New Point(20, 7), New StringFormat With {.Alignment = StringAlignment.Center})
            Case ButtonHover.Close
                G.DrawString("r", ButtonFont, New SolidBrush(Color.White), New Point(Width - 16, 7), New StringFormat With {.Alignment = StringAlignment.Center})
        End Select



        e.Graphics.DrawImage(B, New Point(0, 0))
        G.Dispose() : B.Dispose()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Select Case ButtonState
            Case ButtonHover.Close
                Parent.FindForm().Close()
            Case ButtonHover.Minimize
                Parent.FindForm().WindowState = FormWindowState.Minimized
            Case ButtonHover.Maximize
                Parent.FindForm().WindowState = FormWindowState.Maximized
        End Select
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        ButtonState = ButtonHover.None : Invalidate()
    End Sub
End Class
