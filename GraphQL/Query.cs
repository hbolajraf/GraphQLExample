namespace GraphQLExample.GraphQL
{
    public class Query
    {
        [GraphQLName("hello")]
        public string GetHello() => "Hello world, from GraphQL!";
    }
}
