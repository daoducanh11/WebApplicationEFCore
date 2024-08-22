namespace CIC_TT15.Core.Utils
{
    public class Util
    {
        public static T Map<T>(object source) where T : new()
        {
            T destination = new T();
            foreach (var sourceProp in source.GetType().GetProperties())
            {
                var destProp = typeof(T).GetProperty(sourceProp.Name);
                if (destProp != null && destProp.CanWrite)
                {
                    destProp.SetValue(destination, sourceProp.GetValue(source));
                }
            }
            return destination;
        }
    }
}
