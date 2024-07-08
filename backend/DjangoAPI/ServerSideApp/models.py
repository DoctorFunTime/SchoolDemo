from django.db import models

class Subjects(models.Model):
    
    subjectID = models.AutoField(primary_key=True)
    name = models.CharField(max_length= 100)
    
    
class Students(models.Model):
    
    studentID = models.AutoField(primary_key=True)
    name = models.CharField(max_length=100)
    form = models.IntegerField()
    subject = models.CharField(max_length=100) 
    
