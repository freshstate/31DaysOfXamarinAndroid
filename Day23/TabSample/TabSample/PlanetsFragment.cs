using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace TabSample
{
    public class PlanetsFragment : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Planets, container, false);
        }
    }
}