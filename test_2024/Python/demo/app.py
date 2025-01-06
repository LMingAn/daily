from flask import Flask, send_file, session
from captcha_generator import generate_captcha, generate_random_text
import io

app = Flask(__name__)
app.secret_key = 'your_secret_key'

@app.route('/api/captcha')
def get_captcha():
    captcha_text = generate_random_text()
    session['captcha_text'] = captcha_text
    captcha_image = generate_captcha(captcha_text)
    return send_file(io.BytesIO(captcha_image), mimetype='image/png')

if __name__ == "__main__":
    app.run(debug=True)
