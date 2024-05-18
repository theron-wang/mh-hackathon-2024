﻿namespace DataAccess.Models;
public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public List<Response>? Responses { get; set; }
    public string? Text { get; set; }
}
