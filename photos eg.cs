using System.IO;
using System;

public class PhotoBook
{
    protected int numPages;
    public PhotoBook()
    {
        numPages = 16;
    }
    public PhotoBook(int addPages)
    {
        numPages= addPages;
    }
    public int GetNumberPages()
    {
        return numPages;
    }
}
public class BigPhotoBook:PhotoBook
{
    public int BigPhotos()
    {
        numPages= 64;
        return numPages;
    }
}
public class PhotoBookTest
{
    public static void Main()
    {
        PhotoBook photo = new PhotoBook();
        Console.WriteLine(photo.GetNumberPages());
        PhotoBook Album=new PhotoBook(24);
        Console.WriteLine(Album.GetNumberPages());
        BigPhotoBook album = new BigPhotoBook();
        Console.WriteLine(album.BigPhotos());
    }
}