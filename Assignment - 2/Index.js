const first = document.getElementById('first');

const second = document.getElementById('second');

// 👇️ Change text color on mouseover for div1
first.addEventListener('mouseover', function handleMouseOver() {
  first.style.color = 'red';
});

// 👇️ Change text color back on mouseout for div1
first.addEventListener('mouseout', function handleMouseOut() {
  first.style.color = 'black';
});

// 👇️ Change text color on mouseover for div2
second.addEventListener('mouseover', function handleMouseOver2() {
    second.style.color = 'red';
  });
  
  // 👇️ Change text color back on mouseout for div2
second.addEventListener('mouseout', function handleMouseOut2() {
    second.style.color = 'black';
});