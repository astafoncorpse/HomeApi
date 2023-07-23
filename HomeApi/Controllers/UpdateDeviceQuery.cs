namespace HomeApi.Controllers
{
    public class UpdateDeviceQuery
    {
        private string newName;
        private string newSerial;

        public UpdateDeviceQuery(string newName, string newSerial)
        {
            this.newName = newName;
            this.newSerial = newSerial;
        }
    }
}
