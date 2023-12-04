using RuggedVilla.Controllers;

namespace RuggedVilla.Models.Data
{
    public static class VillaStore
    {
        private const string V = "Beach View";
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            {
                new VillaDto{Id=1, name=V },
                new VillaDto{Id=2, name="Ocean View" }

            };
    }
}
