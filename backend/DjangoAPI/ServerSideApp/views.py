from django.shortcuts import render
from django.views.decorators.csrf import csrf_exempt
from rest_framework.parsers import JSONParser
from django.http.response import JsonResponse
from .serializers import StudentSerializer, SubjectSerializer
from .models import Subjects, Students

@csrf_exempt
def studentsApi(request, id = 0):
    if request.method == "GET":
        students = Students.objects.all()
        students_serializer = StudentSerializer(students, many = True)
        return JsonResponse(students_serializer.data, safe = False)
    
    elif request.method == "POST":
        student_data = JSONParser().parse(request)
        students_serializer = StudentSerializer(data= student_data)
        if students_serializer.is_vald():
            students_serializer.save()
            return JsonResponse("Student Added Successfully")
        return JsonResponse("failed to add student")
    
    elif request.method == "PUT":
        student_data = JSONParser().parse(request)
        student = Students.objects.get(studentID = student_data['studentID'])
        students_serializer = StudentSerializer(student, data= student_data)
        if students_serializer.is_valid():
            students_serializer.save()
            return JsonResponse("Student updated successfully")
        return JsonResponse("failde to update student")
    
    elif request.method == "DELETE":
        student  = Students.objects.get(studentID = id)
        student.delete()
        return JsonResponse("Student Deleted Successfully")