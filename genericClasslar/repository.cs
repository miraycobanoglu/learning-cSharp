namespace genericClasslar;

public class repository<T>
{
    public List<T> Getir()
    {
        //veritabanında ilgili tabloya git ve oradan kayıtları getir

        return null;
    }


public string Ekle(T data)
    {
        //veritabanına git ilgili tabloya şu T tipindeki datayı ekle

        return "data başarılı bir şekilde eklenmiştir";
    }
}