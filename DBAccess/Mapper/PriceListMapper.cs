using DBAccess.DataModel;
using Microsoft.EntityFrameworkCore;

namespace DBAccess.Mapper
{
    public class PriceListMapper
    {
        private Context context;

        public PriceListMapper()
        {
            context = new Context();
        }

        public void Insert ()
        {
            try
            {
                context.PriceLists.Add(new PriceList()
                {
                    StartingDate = new DateOnly(),
                    RoomType = null,
                    Price = 1,
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
                var pl = context.PriceLists.ToList();
                Console.WriteLine(pl.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SelectAll() { }

        public void Update ()
        {
            try
            {
                var pl = context.PriceLists.Where
                    (
                        x => x.StartingDate == null
                    ).ExecuteUpdate
                    (
                        x => x.SetProperty
                        (
                            y => y.StartingDate, null)
                    );
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete ()
        {
            var pl = context.PriceLists.Where
            (
                x => x.StartingDate == null
            );
            try
            {
                context.RemoveRange(pl);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}