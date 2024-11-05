pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        script {
          sh 'dotnet build Lab1.sln' // Replace with your actual solution name, e.g., Lab1.sln
        }
      }
    }
    stage('Docker Build') {
      steps {
        script {
          sh 'docker build -t lab1-api .' // Replace with your desired Docker image name
        }
      }
    }
    stage('Deploy to Staging') {
      steps {
        script {
          sh 'docker-compose up --build -d' // Ensure docker-compose.yml is correctly configured
        }
      }
    }
  }
}
