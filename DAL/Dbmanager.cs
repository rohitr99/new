namespace DAL.connected;
using System.Security.Cryptography.X509Certificates;
using  BOL;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;


public static class Dbmanager{
    
    public static List<Orders>GetAllOrders(){
      
        List<Orders>ord=new List<Orders>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString="server= 192.168.10.150;port=3306;user=dac34;password=welcome;database=dac34";
        string query="select * from orders";
        MySqlCommand command=new MySqlCommand(query,conn);
        try{
            conn.Open();
            MySqlDataReader reader=command.ExecuteReader();
            while(reader.Read()){
                Orders od=new Orders();
                int oid=int.Parse(reader["oid"].ToString());
                string odt=reader["odt"].ToString();
                Console.WriteLine(oid+"  "+odt);
                od.oid=oid;
                od.odt=odt;
                ord.Add(od);
            }
            reader.Close();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
         finally{
            conn.Close();
        }
        return ord;
    }



}