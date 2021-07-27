using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanVienModel
{
    class Database
    {
        const string connectionsString = @"Data Source=DESKTOP-AR829C3\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";

        SqlConnection Connect = new SqlConnection(connectionsString);

        public Boolean isValid(string[] keys, string[] values)
        {
            if (keys.Length != values.Length)
            {
                MessageBox.Show("Trường tên cột và trường giá trị không trùng nhau.", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (string value in values)
            {
                string check = value;
                check = check.Replace("N'", "");
                check = check.Replace("'", "");

                if (check == "")
                {
                    MessageBox.Show("Bạn nhập thiếu thông tin. Vui lòng kiểm tra lại.", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        public DataTable read(string table, string[] selectWhat, string key = "", string value = "")
        {
            Connect.Open();

            string what = "";
            string where = "";

            if (selectWhat.Length == 0 || selectWhat == null)
                what = "*";
            else
                what = string.Join(", ", selectWhat);

            if (key != "" && value != "")
                where = " WHERE " + key + " = N'" + value + "'";

            string Read = "SELECT " + what + " FROM " + table + where;

            SqlCommand Query = new SqlCommand(Read, Connect);
            Query.CommandType = CommandType.Text;

            SqlDataAdapter Data = new SqlDataAdapter(Query);
            DataTable ReadData = new DataTable();

            Data.Fill(ReadData);
            Data.Dispose();
            
            Connect.Close();

            return ReadData;
        }

        public void store(string table, string[] keys, string[] values)
        {
            Connect.Open();

            if (this.isValid(keys, values))
            {
                try
                {
                    string keyList = string.Join(", ", keys);
                    string valueList = string.Join(", ", values);

                    string Insert = "INSERT INTO " + table + " (" + keyList  + ") VALUES(" + valueList + ")";
                    
                    SqlCommand Query = new SqlCommand(Insert, Connect);
                    Query.ExecuteNonQuery();
                    
                    MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra ! Vui lòng kiểm tra lại.", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        
            Connect.Close();
        }

        public void update(string table, string[] keys, string[] values, string key, string value)
        {
            Connect.Open();

            if (this.isValid(keys, values))
            {
                try
                {
                    string list = "";
                    int i = 0;

                    foreach(string oneKey in keys)
                    {
                        list += oneKey + " = " + values[i];
                        if (i != keys.Length - 1)
                            list += ", ";
                        i++;
                    }
                    
                    string Update = "UPDATE " + table + " SET " + list + " WHERE " + key + " = " + value;

                    SqlCommand Query = new SqlCommand(Update, Connect);
                    Query.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra ! Vui lòng kiểm tra lại.", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            Connect.Close();
        }

        public void delete(string table, string key, string value)
        {
            Connect.Open();

            
            try
            {
                string Delete = "DELETE FROM " + table + " WHERE " + key + " = " + value;

                SqlCommand Query = new SqlCommand(Delete, Connect);
                Query.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra ! Vui lòng kiểm tra lại.", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connect.Close();
        }

    }
}
