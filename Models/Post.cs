using Amazon.DynamoDBv2.DataModel;

namespace Blog.Models
{
    [DynamoDBTable(tableName: "post")]
    public class Post
    {
        public Post() => Id = Guid.NewGuid();

        [DynamoDBHashKey]
        public Guid Id { get; set; }
        public DateTime PostDateTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
