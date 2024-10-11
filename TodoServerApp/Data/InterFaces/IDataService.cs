namespace TodoServerApp.Data.InterFaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
    }
}
