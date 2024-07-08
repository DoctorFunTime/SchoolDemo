from rest_framework import serializers

from .models import Students, Subjects


class SubjectSerializer(serializers.ModelSerializer):
    class Meta:
        model = Subjects
        fields = ['__all__']
        
class StudentSerializer(serializers.ModelSerializer):
    class Meta:
        model = Students
        fields = ['__all__']