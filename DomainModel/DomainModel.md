```mermaid

---
title: Canvas
---
classDiagram

  class User
  User : +String owner
  User : +String email
  User : +List<Course> schedule

  class Course
  Course : +String title
  Course : +int section
  Course : +date meetingTimes
  Course : +Professor Professor
  Course : +List<Module> modules

  class Dashboard
  Dashboard : +displayCourses(List<Course>)
  Dashboard : +selectCourse(Course)
  Dashboard : +showToDoList(List<Task>)

  class Task
  Task : +Assignment assignment
  Task : +Announcement announcement 

  Dashboard o-- Course
  Dashboard o-- Task
  User *-- Dashboard
  Course *-- Module
  Course *-- Assignment
  Course *-- Announcement 
  Course *-- Grader
  Course o-- Professor


  class Module
  Module : +String title
  Module : +List<Link> links
  Module : +goTo(Link)

  class Assignment
  Assignment : +String instructions
  Assignment : +String title
  Assignment : +submit(File)
  Assignment : -float grade

  class Announcement 
  Announcement : +String title
  Announcement : +String body

  class Grader
  Grader : -float courseGrade
  Grader : -List<Assignment> gradedWork
  Grader : -calculateGrade(List<float>)

  User <-- Professor
  
  ```