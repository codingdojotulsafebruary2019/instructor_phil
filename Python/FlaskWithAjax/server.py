from flask import Flask, render_template, redirect, request
import json
from user import Cohort

app = Flask(__name__)
# get instance of cohort to simulate DB

cohort = Cohort()
@app.route("/")
def index():
    return render_template("index.html", cohort = cohort)

@app.route("/process", methods=["post"])
def process():
    student = cohort.add(request.form["name"], request.form["location"])
    return json.dumps(student.__dict__)

app.run(debug=True)