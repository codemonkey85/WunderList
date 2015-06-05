﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WunderListSample.Models
{
    public class WunderJson
    {
    }
    
public class Rootobject
{
public int user { get; set; }
public string exported { get; set; }
public Data data { get; set; }
}

public class Data
{
public List[] lists { get; set; }
public Task[] tasks { get; set; }
public Reminder[] reminders { get; set; }
public Subtask[] subtasks { get; set; }
public Note[] notes { get; set; }
public Task_Positions[] task_positions { get; set; }
public Subtask_Positions[] subtask_positions { get; set; }
}

public class List
{
public int id { get; set; }
public string title { get; set; }
public string owner_type { get; set; }
public int owner_id { get; set; }
public string list_type { get; set; }
public bool _public { get; set; }
public int revision { get; set; }
public DateTime created_at { get; set; }
public string type { get; set; }
public string created_by_request_id { get; set; }
}

public class Task
{
public int id { get; set; }
public DateTime created_at { get; set; }
public int created_by_id { get; set; }
public string created_by_request_id { get; set; }
public bool completed { get; set; }
public DateTime completed_at { get; set; }
public int completed_by_id { get; set; }
public bool starred { get; set; }
public int list_id { get; set; }
public int revision { get; set; }
public string title { get; set; }
public string type { get; set; }
public string due_date { get; set; }
public string recurrence_type { get; set; }
public int recurrence_count { get; set; }
}

public class Reminder
{
public int id { get; set; }
public DateTime date { get; set; }
public int task_id { get; set; }
public int revision { get; set; }
public DateTime created_at { get; set; }
public DateTime updated_at { get; set; }
public string created_by_request_id { get; set; }
public string type { get; set; }
}

public class Subtask
{
public int id { get; set; }
public int task_id { get; set; }
public bool completed { get; set; }
public DateTime created_at { get; set; }
public int created_by_id { get; set; }
public string created_by_request_id { get; set; }
public int revision { get; set; }
public string title { get; set; }
public string type { get; set; }
public DateTime completed_at { get; set; }
}

public class Note
{
public int id { get; set; }
public int revision { get; set; }
public string content { get; set; }
public string type { get; set; }
public int task_id { get; set; }
public string created_by_request_id { get; set; }
}

public class Task_Positions
{
public int id { get; set; }
public int list_id { get; set; }
public int revision { get; set; }
public int?[] values { get; set; }
public string type { get; set; }
}

public class Subtask_Positions
{
public int id { get; set; }
public int task_id { get; set; }
public int revision { get; set; }
public int?[] values { get; set; }
public string type { get; set; }
}

}