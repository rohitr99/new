namespace BLL;
using DAL.connected;
using BOL;
public class CatlogManager{
    public  List<Orders> GetOrders(){
    List<Orders> ord=new List<Orders>();
    ord =Dbmanager.GetAllOrders();
    return ord;
    }

}