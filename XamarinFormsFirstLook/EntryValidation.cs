using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
    public class EntryValidation : TriggerAction<Entry>
    {
        public EntryValidation()
        {
        }

        protected override void Invoke(Entry sender)
        {
            int parsedAge;

            bool isValid = int.TryParse(sender.Text, out parsedAge);

            if (!isValid)
            {
                sender.TextColor = Color.Red;
            }
            else {
                sender.TextColor = Color.Blue;
            }
        }
    }
}