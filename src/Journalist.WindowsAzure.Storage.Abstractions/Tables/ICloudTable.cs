namespace Journalist.WindowsAzure.Storage.Tables
{
    public interface ICloudTable
    {
        IBatchOperation PrepareBatchOperation();

        ICloudTableEntityQuery PrepareEntityPointQuery(string partitionKey, string rowKey, string[] properties);

        ICloudTableEntityQuery PrepareEntityPointQuery(string partitionKey, string[] properties);

        ICloudTableEntityRangeQuery PrepareEntityFilterRangeQuery(string filter, string[] properties);

        ICloudTableEntitySegmentedRangeQuery PrepareEntityFilterSegmentedRangeQuery(string filter, string[] properties);
    }
}
