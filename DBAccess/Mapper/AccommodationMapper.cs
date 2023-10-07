using DBAccess.DataModel;
using Microsoft.EntityFrameworkCore;

namespace DBAccess.Mapper
{
    public class AccommodationMapper
    {
        private Context context;

        public AccommodationMapper()
        {
            context = new Context();
        }

        public void Insert()
        {
            try
            {
                context.Accommodations.Add(new Accommodation()
                {
                    CheckIn = new DateOnly(),
                    CheckOut = new DateOnly(),
                    PriceList = new List<PriceList> { }
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
                var ac = context.Accommodations.ToList();
                Console.WriteLine(ac.ToString());
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
                var ac = context.Accommodations.Where
                    (
                        x => x.CheckIn == null
                    ).ExecuteUpdate
                    (
                        x => x.SetProperty
                        (
                            y => y.CheckIn, null)
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
            var ac = context.Accommodations.Where
            (
                x => x.CheckIn == null
            );
            try
            {
                context.RemoveRange(ac);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}