using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetByID;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            DateToFinish = DateTime.Now,
            Description = "Trilha de C# da Rocketseat",
            Name = "Estudar C#",
            Priority = 0,
            Status = Communication.Enums.TaskStatusEnum.IN_PROGRESS
        };
    }
}
