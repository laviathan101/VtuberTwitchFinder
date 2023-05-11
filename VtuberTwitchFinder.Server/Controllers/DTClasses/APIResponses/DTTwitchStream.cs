﻿namespace VtuberTwitchFinder.Server.Controllers.DTClasses.APIResponses;

public class DTTwitchStream
{
    public string id { get; set; }
    public string user_id { get; set; }
    public string user_login { get; set; }
    public string user_name { get; set; }
    public string game_id { get; set; }
    public string game_name { get; set; }
    public string type { get; set; }
    public string title { get; set; }
    public List<string> tags { get; set; }
    public int viewer_count { get; set; }
    public DateTime started_at { get; set; }
    public string language { get; set; }
    public string thumbnail_url { get; set; }
    public List<object> tag_ids { get; set; }
    public bool is_mature { get; set; }
    public string profile_image_url { get; set; }
}