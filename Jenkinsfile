pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                script {
                    bat 'Lab1.sln'
                }
            }
        }
        stage('Docker Build') {
            steps {
                script {
                    bat 'docker build -t lab1-api .'
                }
            }
        }
        stage('Deploy to Staging') {
            steps {
                script {
                    bat 'docker-compose up --build -d'
                }
            }
        }
    }
}
