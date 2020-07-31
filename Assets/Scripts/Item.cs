using UnityEngine;
using TMPro;

// [CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
  public string commonName ="commonName";
  public string scientificName = "scientificName";
  public int age =5;
  public int weight =4;
//   private int[] dimensions = {height, width, depth};
  public int height =3;
  public int width =2;
  public int depth = 1;
  public string description ="description";
  public string funFacts ="funFacts";
  public Sprite img1 =null;
  public Sprite img2 =null;
  public Sprite img3 =null;

}
