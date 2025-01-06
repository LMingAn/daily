export function generateCaptcha() {
  const chars = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
  let captcha = '';
  for (let i = 0; i < 4; i++) {
    captcha += chars[Math.floor(Math.random() * chars.length)];
  }
  return captcha;
}
