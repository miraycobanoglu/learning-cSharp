namespace lokanta;

public class ikramlikmeze : Iikramlik
{
 public int mezefiyat {  get; set; }
 public void ekle()
 {
  Console.WriteLine("ikramlık meze eklendi");
 }

 public void sil()
 {
  Console.WriteLine("ikramlık meze eklenmedi");
 }
}
