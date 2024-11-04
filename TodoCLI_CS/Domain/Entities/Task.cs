using TodoCLI_CS.Domain.VOs;

namespace TodoCLI_CS.Domain.Entities
{
    public class Task
    {
        private readonly Guid _id;
        private Title _title;
        private Description _description;
        private Deadline _deadline;
        private readonly DateTime _createdAt;
        private DateTime _updatedAt;
        private bool _isCompleted;
        private bool _isDeleted;

        public Task(Title title, Description description, Deadline deadline)
        {
            if (title == null)
            {
                throw new ArgumentNullException("title must not be null");
            }

            if (description == null)
            {
                throw new ArgumentNullException("description must not be null");
            }

            if (deadline == null)
            {
                throw new ArgumentNullException("deadline must not be null");
            }

            _id = Guid.NewGuid();
            _title = title;
            _description = description;
            _deadline = deadline;
            _createdAt = DateTime.UtcNow;
            _updatedAt = DateTime.UtcNow;
            _isCompleted = false;
            _isDeleted = false;
        }

        public void Update(Title title, Description description, Deadline deadline)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title), "title must not be null");
            }

            if (description == null)
            {
                throw new ArgumentNullException("description must not be null");
            }

            if (deadline == null)
            {
                throw new ArgumentNullException("deadline must not be null");
            }

            _title = title;
            _description = description;
            _deadline = deadline;
        }

        public void Complete()
        {
            if (_isDeleted)
            {
                throw new InvalidOperationException("cannot complete a deleted task");
            }

            _isCompleted = true;
            _updatedAt = DateTime.UtcNow;
        }

        public void Delete()
        {
            if (_isDeleted)
            {
                throw new InvalidOperationException("task is already deleted");
            }

            _isDeleted = true;
        }

        public Guid Id => _id;
        public Title Title => _title;
        public Description Description => _description;
        public Deadline Deadline => _deadline;
        public bool IsCompleted => _isCompleted;
        public bool IsDeleted => _isDeleted;
    }
}
