namespace AEDEmpleados.Util
{
    public static class ImageUtil
    {
        public static byte[] ToByteArray(this Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        public static Image ToImage(this byte[] array)
        {
            using var ms = new MemoryStream(array);
            return Image.FromStream(ms);
        }
    }
}