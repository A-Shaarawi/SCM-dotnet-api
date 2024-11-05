pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        script {
          // Use your actual solution file name
          bat 'dotnet build Lab1.sln'
        }
      }
    }
    stage('Docker Build') {
      steps {
        script {
          // Build the Docker image with the specified image name
          bat 'docker build -t lab1-api .'
        }
      }
    }
    stage('Deploy to Staging') {
      steps {
        script {
          // Deploy the image using docker-compose
          bat 'docker-compose up --build -d'
        }
      }
    }
  }
}
