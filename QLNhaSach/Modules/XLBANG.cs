using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLNhaSach.Modules
{
    class XLBANG: DataTable
    {
        #region Fields
        public static string cnnStr = @"Data Source=LAPTOP-ME3QPJ97\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True";
        private static SqlConnection _cnn;
        private SqlDataAdapter _da = new SqlDataAdapter();
        private string _query; // Cau truy van
        private string _name; // Ten table
        #endregion
        #region Properties
        public string query
        {
            get { return _query; }
            set { _query = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int getCount // Lay so record
        {
            get { return this.DefaultView.Count; }
        }
        #endregion
        #region Consructors
        public XLBANG() : base() { }
        public XLBANG(string pName)
        {
            _name = pName;
            docBang();
        }
        public XLBANG(string pName, string pQuery)
        {
            _name = pName;
            _query = pQuery;
            docBang();
        }
        #endregion
        #region Methods
        //Doc du lieu
        public void docBang()
        {
            if (_query == null)
                _query = "Select * from " + _name;
            if (_cnn == null)
                _cnn = new SqlConnection(cnnStr);
            try
            {
                _da = new SqlDataAdapter(_query, _cnn);
                _da.FillSchema(this, SchemaType.Mapped);
                _da.Fill(this);
                _da.RowUpdated += new SqlRowUpdatedEventHandler(da_RowUpdated);
                SqlCommandBuilder cmmb = new SqlCommandBuilder(_da);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Ghi du lieu
        public Boolean ghi()
        {
            Boolean result = true;
            try
            {
                _da.Update(this);
                this.AcceptChanges();
            }
            catch (SqlException ex)
            {
                this.RejectChanges();
                result = false;
                throw ex;
            }
            return result;
        }
        //Loc du lieu
        public void locDuLieu(string pDieuKien)
        {
            try
            {
                this.DefaultView.RowFilter = pDieuKien;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Thực hiện câu truy vấn cập nhật dữ liệu (Insert, Update, Delete)
        public static int Thuc_hien_lenh(String pQuery)
        {
            if (_cnn == null)
                _cnn = new SqlConnection(cnnStr);
            try
            {

                SqlCommand cmd = new SqlCommand(pQuery, _cnn);
                _cnn.Open();
                int result = cmd.ExecuteNonQuery();
                _cnn.Close();
                return result;
            }
            catch
            {
                return -1;
            }
        }
        //Thực hiện câu truy vấn trả về một giá trị
        public static Object Thuc_hien_lenh_tinh_toan(String pQuery)
        {
            if (_cnn == null)
                _cnn = new SqlConnection(cnnStr);
            try
            {
                SqlCommand cmd = new SqlCommand(pQuery, _cnn);
                _cnn.Open();
                Object result = cmd.ExecuteScalar();
                _cnn.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }

        //Goi Store Procedure
        public static Object Thuc_hien_StoreProcedure(String nameProc, SqlParameter[] p)
        {
            if (_cnn == null)
                _cnn = new SqlConnection(cnnStr);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProc;
                //Add Parameters
                cmd.Parameters.AddRange(p);
                _cnn.Open();
                Object result = cmd.ExecuteScalar();
                _cnn.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }

        #endregion
        #region Events
        //Xử lý sự kiện Rowupdated đối với trường khóa chính có kiểu Autonumber 
        private void da_RowUpdated(Object sender, SqlRowUpdatedEventArgs e)
        {
            if (this.PrimaryKey[0].AutoIncrement)
            {
                if ((e.Status == UpdateStatus.Continue) && (e.StatementType == StatementType.Insert))
                {
                    SqlCommand cmd = new SqlCommand("Select @@IDENTITY ", _cnn);
                    e.Row.ItemArray[0] = cmd.ExecuteScalar();
                    e.Row.AcceptChanges();
                }
            }
        }
        #endregion

    }
}