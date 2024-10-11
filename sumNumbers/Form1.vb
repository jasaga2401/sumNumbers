Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnSumNumbers_Click(sender As Object, e As EventArgs) Handles btnSumNumbers.Click

        Dim startNumber As Integer = Convert.ToInt32(txtStartNumber.Text)
        Dim endNumber As Integer = Convert.ToInt32(txtEndNumber.Text)

        Dim connectionString As String = "Server=localhost; Database=dbuser; User ID=root; Password=12Yellow34!"

        Using conn As New MysqlConnection(connectionString)

            conn.Open()

            ' Create a MySQL command to call the stored procedure
            Using cmd As New MySqlCommand("sp_calculate_sum", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Add input parameters for the stored procedure
                cmd.Parameters.AddWithValue("@start_num", startNumber)
                cmd.Parameters.AddWithValue("@end_num", endNumber)

                ' Add output parameter for the total sum
                Dim totalSumParam As New MySqlParameter("@total_sum", MySqlDbType.Int32)
                totalSumParam.Direction = ParameterDirection.Output
                cmd.Parameters.Add(totalSumParam)

                ' Execute the stored procedure
                cmd.ExecuteNonQuery()

                ' Get the output parameter value
                ' Retrieve and display the total sum result
                Dim totalSum As Integer = Convert.ToInt32(cmd.Parameters("@total_sum").Value)
                txtSumTotal.Text = totalSum.ToString()
                'MessageBox.Show("The sum from " & startNumber & " to " & endNumber & " is: " & totalSum.ToString())

            End Using

        End Using



    End Sub
End Class
