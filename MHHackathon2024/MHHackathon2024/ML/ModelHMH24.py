import numpy as np 
import pandas as pd
from matplotlib import pyplot as plt
import seaborn as sns
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier
from sklearn.ensemble import RandomForestClassifier
from sklearn.preprocessing import StandardScaler
import sys



df = pd.read_csv("student_industry_correlated.csv")
df.nunique()


X=df.drop(['Industry'],axis=1)
Y=df['Industry']
X_train,X_test,Y_train,Y_test=train_test_split(X,Y,test_size=.3,random_state=7)


#RandomForrest Model

rand_clf=RandomForestClassifier(n_estimators=20,criterion="entropy")
rand_clf.fit(X_train,Y_train)
y_pred=rand_clf.predict(X_test)

#print('Training-set accuracy score:', rand_clf.score(X_train, Y_train))
#print('Testing-set accuracy score:', rand_clf.score(X_test, Y_test))


input_string = sys.argv[1]
#print(input_string)

testing = [int(num) for num in input_string.split(',') if num]
testing = np.array(testing).reshape(1, -1)
if testing.shape[1] != len(X.columns):
    print("Error: The number of elements in the test input does not match the number of features in the model.")
test_df = pd.DataFrame(testing, columns=X.columns)
#print("Array of numbers:", testing)

prediction = rand_clf.predict(test_df)
print(str(prediction[0]))
