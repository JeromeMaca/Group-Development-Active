Public Class CurrencyTextBox
    ' How to use:
    ' Compile this then go to the bin directories. Copy the release dll and paste it in your project folder. 
    ' Reference it from there. Then go to the toolbox for the gui components then click add more. There find
    ' reference the dll in your project folder. This has been tested to work on Microsoft Visual Studio 2010
    ' Ultimate. I assume this will work on all versions of Visual Studio 2010. For flexibility here are the 
    ' parts that you should change depending on your location/currency:
    '   1. Using replace text (ctrl+h), replace all occurences of "en-PH" with your desired location code.
    '   2. There are parts of the world that use the format "9.876.543,21" if you use this format, using 
    '      replace text (ctrl+h), replace all occurences of 46 to 44. You have nothing to change if you use
    '      PhP as your currency and if you use "9,876,543.21" format.
    ' Using as a control:
    '   1. When you want to change the value of the text programmatically follow this statement:
    '           CurrencyTextBox1.Text = "9876543.21" or CurrencyTextBox1.Text = MyDecimal
    '      In that case "9876543.21" can be string, or MyDecimal can be both string and any numeric
    '      variable. 
    '   2. If you want to get the value of the currency not in the formatted mode, you can use
    '           MyDecimal = CurrencyTextBox1.Value ' Dont use .Text since it will output the formatted code.
    ' Programmed by: Bangon Kali 
    ' Email: bangonkali@gmail.com
    ' You may erase this after reading. 

    Inherits System.Windows.Forms.TextBox

    Const LOCATIONCODE As String = "en-PH"
    Const DECIMALPOINT As Integer = 46
    Const CURRFORM As String = "C"

    Private mDecimalPeriod As Boolean = False
    Private mNumberFormat As System.Globalization.NumberFormatInfo = New System.Globalization.CultureInfo(LOCATIONCODE, False).NumberFormat
    Private mBuffer As String = ""

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            Try
                MyBase.Text = Decimal.Parse(value, Globalization.NumberStyles.Currency, mNumberFormat).ToString(CURRFORM, mNumberFormat)
            Catch ex As Exception
                MyBase.Text = "0"
            End Try
        End Set
    End Property

    Public ReadOnly Property Value As Decimal
        Get
            If MyBase.Text.Length = 0 Then
                MyBase.Text = "0"
            End If
            Return Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat)
        End Get
    End Property

    Private Sub DecimalTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        If MyBase.Text.Length = 0 Then
            MyBase.Text = "0"
        End If
        MyBase.Text = Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat).ToString
    End Sub

    Private Sub DecimalTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        If MyBase.Text.Length = 0 Then
            MyBase.Text = "0"
        End If
        MyBase.Text = Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat).ToString(CURRFORM, mNumberFormat)
        mDecimalPeriod = False
    End Sub

    Private Sub DecimalTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        mBuffer = MyBase.Text
        If e.KeyChar = Chr(8) Then
            If MyBase.Text.Length = 0 Then Exit Sub
            If MyBase.Text.Chars(MyBase.Text.Length - 1) = Chr(DECIMALPOINT) Then
                mDecimalPeriod = False
            End If
            Exit Sub
        ElseIf Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = Chr(DECIMALPOINT) Then
                If MyBase.Text.Length = 0 And MyBase.SelectionLength = 0 Then
                    e.Handled = True
                    Exit Sub
                End If
                If mDecimalPeriod = False And MyBase.SelectionLength = 0 Then
                    mDecimalPeriod = True
                    Exit Sub
                Else
                    e.Handled = True
                End If
            End If
            e.Handled = True
            Exit Sub
        End If
        If IsNumber(Text) = False Then
            MyBase.Text = mBuffer
        End If
    End Sub

    Private Function IsNumber(ByVal str As String) As Boolean
        Dim iCounter As Integer
        Dim bValidator As Boolean
        For iCounter = 0 To str.Length - 1
            If Char.IsDigit(str.Chars(iCounter)) = False Then
                If str.Chars(iCounter) = Chr(DECIMALPOINT) And bValidator = False Then
                    bValidator = True
                Else
                    Return False
                    Exit Function
                End If
            End If
        Next

        Return True
    End Function

    Private Sub DecimalTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        MyBase.SelectAll()
    End Sub

    Private Sub DecimalTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        If MyBase.Enabled = False Or MyBase.ReadOnly = True Then
            MyBase.Text = Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat).ToString(CURRFORM, mNumberFormat)
        End If
    End Sub

End Class
