namespace TodoCLI_CS.Domain.Repositories
{
    public interface ITaskRepository
    {
        // 新しいタスクを追加する
        void Add(Entities.Task task);

        // IDによってタスクを取得する
        Entities.Task GetById(Guid id);

        // タスクを更新する
        void Update(Entities.Task task);

        // タスクを削除する
        void Delete(Guid id);

        // すべてのタスクを取得する
        IEnumerable<Entities.Task> GetAllTasks();
    }
}
