.container {
  max-width: 1100px;
  padding: 0 30px;
  margin: 0 auto;
  overflow: auto;
}

.btn-secondary, .btn-primary {
  display: inline-block;
  border-radius: 5px;
  padding: 8px 20px;
  margin: 3px;
}
.btn-secondary:hover, .btn-primary:hover {
  transform: scale(0.98);
}

.btn-primary {
  background-color: #418bff;
  color: #fff;
}

.btn-secondary {
  background-color: #ff9f33;
  color: #fff;
}

* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

body {
  background-color: #f4f4f4;
  font-family: Arial, Helvetica, sans-serif;
  line-height: 1.6;
}

img {
  width: 100%;
}

.showcase {
  background-color: #0e6cff;
  color: #fff;
  height: 600px;
}
.showcase nav {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.showcase nav ul {
  display: flex;
  list-style-type: none;
}
.showcase nav li {
  padding: 15px;
}
.showcase nav a:hover {
  color: #ff8700;
}
.showcase a {
  color: #fff;
}
.showcase-content {
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
}
.showcase-content img {
  width: 50%;
}
.showcase-content h1 {
  font-size: 50px;
  line-height: 1.2;
}
.showcase-content p {
  margin: 20px 0;
}

@media (max-width: 700px) {
  .showcase {
    height: 400px;
  }
  .showcase-content {
    text-align: center;
  }
  .showcase img {
    display: none;
  }
}

/*# sourceMappingURL=style.cs.map */
