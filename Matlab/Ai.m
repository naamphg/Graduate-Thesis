function y = Ai(a, alpha, d, theta)

y1 = [cos(theta) -(cos(alpha)*sin(theta)) (sin(alpha)*sin(theta)) a*cos(theta)];
y2 = [sin(theta) (cos(alpha)*cos(theta)) -(sin(alpha)*cos(theta)) a*sin(theta)];
y3 = [0 sin(alpha) cos(alpha) d];
y4 = [0 0 0 1];

y = [y1 ; y2; y3; y4];
end
