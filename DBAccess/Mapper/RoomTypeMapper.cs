using DBAccess.DataModel;
using Microsoft.EntityFrameworkCore;

namespace DBAccess.Mapper
{
    public class RoomTypeMapper
    {
        private Context context;

        public RoomTypeMapper()
        {
            context = new Context();
        }

        public void Insert()
        {
            try
            {
                context.RoomTypes.Add(new RoomType()
                {
                    Type = "",
                    Level = 1
                });

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Select()
        {
            try
            {
                var rt = context.RoomTypes.ToList();
                Console.WriteLine(rt.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SelectAll() { }

        public void Update()
        {
            try
            {
                var rt = context.RoomTypes.Where
                    (
                        x => x.Type == null
                    ).ExecuteUpdate
                    (
                        x => x.SetProperty
                        (
                            y => y.Type, "")
                    );
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete()
        {
            var rt = context.RoomTypes.Where
            (
                x => x.Type == null
            );
            try
            {
                context.RemoveRange(rt);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}