namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The MoveResourceResultViewModel. This is model class is needed by the hierarchy.MoveResource stored proc, which
    /// returns a list of nodeIds affected by the moved resource.
    /// </summary>
    public class MoveResourceResultViewModel
    {
        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        [Key]
        public int NodeId { get; set; }
    }
}
