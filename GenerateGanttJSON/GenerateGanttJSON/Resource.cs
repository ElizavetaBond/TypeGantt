using System.Collections.Generic;
using Newtonsoft.Json;

namespace GenerateGanttJSON
{
    public class Resource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tasks")]
        public List<Task> Tasks { get; set; }

        public Resource(string name, List<Task> tasks)
        {
            Name = name;
            Tasks = tasks;
        }

        public static List<Resource> FromJson(string json) => JsonConvert.DeserializeObject<List<Resource>>(json, Converter.Settings);
    }
}