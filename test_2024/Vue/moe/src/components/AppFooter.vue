<template>
  <footer class="app-footer">
    <div class="footer-content">
      <p class="footer-text">© 2024 我的百科 - 所有权利保留</p>
      <div class="social-links">
        <a href="https://github.com" target="_blank" class="social-link">GitHub</a>
        <a href="https://twitter.com" target="_blank" class="social-link">Twitter</a>
        <a href="https://facebook.com" target="_blank" class="social-link">Facebook</a>
      </div>
    </div>
  </footer>
</template>

<script>
export default {
  name: 'AppFooter',
};
</script>

<style scoped>
.app-footer {
  background-color: #2c3e50; /* 深色背景 */
  color: #ecf0f1;
  padding: 30px 20px;
  text-align: center;
  font-size: 0.9rem;
  box-shadow: 0 -4px 6px rgba(0, 0, 0, 0.1);
}

.footer-content {
  max-width: 1200px;
  margin: 0 auto;
}

.footer-text {
  margin-bottom: 10px;
}

.social-links {
  display: flex;
  justify-content: center;
  gap: 20px;
}

.social-link {
  color: #ecf0f1;
  text-decoration: none;
  font-size: 1.1rem;
  transition: color 0.3s;
}

.social-link:hover {
  color: #3498db; /* 鼠标悬浮时的颜色 */
}

@media (max-width: 768px) {
  .social-links {
    flex-direction: column;
    align-items: center;
  }
  .social-link {
    margin: 5px 0;
  }
}
</style>
