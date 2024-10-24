using RPS.Core.Models;
using RPS.Core.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace RPS.Web.Models.Forms
{
    public class DetailsFormModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Estimate { get; set; }
        public PriorityEnum SelectedPriority { get; set; }
        public StatusEnum SelectedStatus { get; set; }
        public ItemTypeEnum SelectedItemType { get; set; }

        public int SelectedAssigneeId { get; set; }

        public readonly List<ItemTypeEnum> ItemTypes = new List<ItemTypeEnum> { ItemTypeEnum.Bug, ItemTypeEnum.Chore, ItemTypeEnum.Impediment, ItemTypeEnum.PBI };
        public readonly List<StatusEnum> Statuses = new List<StatusEnum> { StatusEnum.Closed, StatusEnum.Open, StatusEnum.ReOpened, StatusEnum.Submitted };
        public readonly List<PriorityEnum> Priorities = new List<PriorityEnum> { PriorityEnum.Critical, PriorityEnum.High, PriorityEnum.Low, PriorityEnum.Medium };
        public List<PtUser> Users = new List<PtUser>();

    }
}
