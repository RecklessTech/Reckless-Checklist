using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RecklessCheckList.Data;

namespace RecklessCheckList.Models
{
    public class TaskRepository
    {
        public TaskRepository() { }

        public TaskList GetTasks()
        {
            TaskList list = new TaskList();
            list.Tasks = new List<Task>();

            using (RecklessCheckListEntities context = new RecklessCheckListEntities())
            {
                list.Tasks = (from t in context.TASKs.Include("TASK_VALUE")
                            select new Task() { Id = t.TASK_ID, Name = t.NAME, Value = t.TASK_VALUE.NAME }).ToList();
            }

            return list;
        }

        public Task GetTask(Int32 taskId)
        {
            Task task = new Task();

            using (RecklessCheckListEntities context = new RecklessCheckListEntities())
            {
                var taskSelect = from t in context.TASKs.Include("TASK_VALUE")
                                 where t.TASK_ID == taskId
                                 select t;

                if (taskSelect.Count() == 1)
                {
                    TASK selectedTask = taskSelect.First();

                    task = new Task() { Id = selectedTask.TASK_ID, Value = selectedTask.TASK_VALUE.NAME, Name = selectedTask.NAME };
                }

            }

            return task;
        }


        public TaskResponse ToggleTask(Int32 taskId)
        {

            TaskResponse response = new TaskResponse();


            using (RecklessCheckListEntities context = new RecklessCheckListEntities())
            {

                var taskSelect = from t in context.TASKs.Include("TASK_VALUE")
                                 where t.TASK_ID == taskId
                                 select t;

                if (taskSelect.Count() == 1)
                {

                    TASK contextTask = taskSelect.First();
                    response.OldStatus = contextTask.TASK_VALUE.NAME;

                    Int32 valueId = ((contextTask.TASK_VALUE_ID + 1) % 4);
                    if (valueId == 0)
                        valueId = 4;

                    contextTask.TASK_VALUE_ID = valueId;

                    context.SaveChanges();

                    var status = (from s in context.TASK_VALUE
                                  where s.TASK_VALUE_ID == contextTask.TASK_VALUE_ID
                                  select s.NAME).First();

                    response.NewStatus = status;
                    response.Completed = true;
                }
                else
                {
                    response.Completed = false;
                }
            }

            return response;

        }


        public Task ChangeState(Int32 taskId, String status)
        {
            Task task = new Task();


            using (RecklessCheckListEntities context = new RecklessCheckListEntities())
            {

                Int32 valueId = (from v in context.TASK_VALUE
                                where v.NAME == status
                                select v.TASK_VALUE_ID).First();


                var taskSelect = from t in context.TASKs.Include("TASK_VALUE")
                                 where t.TASK_ID == taskId
                                 select t;

                if (taskSelect.Count() == 1)
                {

                    TASK contextTask = taskSelect.First();

                    contextTask.TASK_VALUE_ID = valueId;

                    context.SaveChanges();

                    task = new Task() { Id = contextTask.TASK_ID, Value = status, Name = contextTask.NAME };
                }


            }

            return task;
        }

    }
}